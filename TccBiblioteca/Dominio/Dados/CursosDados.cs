using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using TccBiblioteca.Classes;

namespace TccBiblioteca.Dados
{
    public class CursosDados
    {
        DadosMySQL dados = new DadosMySQL();

        #region Cadastrar
        public void Incluir(Curso cursos)
        {
            try
            {
                string sql = "insert into Curso (nome, idExcluir) values (@Nome, 1)";
                dados.ConvertSqlToInt(sql, new MySqlParameter("@Nome", cursos.nomeCurso));
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        #endregion

        #region Consultar
        public DataTable consultar(Curso cursos)
        {
            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                "SELECT Nome, idcurso FROM Curso where idExcluir = 1 ");

            return tblRecuperada;
        }
        #endregion

        #region BuscarPorCodigo
        internal Curso BuscarPorCodigo(int codigoCurso)
        {
            DataTable tblRecuperada = dados.ConvertSqlToDataTable("SELECT Nome FROM Curso WHERE IdCurso = @ID and idExcluir = 1",
                                                                  new MySqlParameter("@ID", codigoCurso));

            if (tblRecuperada.Rows.Count == 0)
                return null;

            Curso curso = new Curso();
            curso.idCurso = codigoCurso;
            curso.nomeCurso = tblRecuperada.Rows[0]["Nome"].ToString();

            return curso;
        }
        #endregion

        #region Pesquisar curso repetido
        public bool PesquisarCursoRep(string nome)
        {
            try
            {
                string sql = "Select nome, idExcluir from Curso where nome = @nome AND idExcluir = 1 ";


                if (dados.ConvertSqlToDataTable(sql, new MySqlParameter("@nome", nome)).Rows.Count > 0)
                    return true;


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;

        }
        #endregion
        
        #region EXCLUISAO LOGICA
        public void Excluir(Curso cursos)
        {
            try
            {
                string sql = "UPDATE curso SET nome = @nome, idExcluir = 0 where @idCurso = idCurso ";
                dados.ConvertSqlToInt(sql, new MySqlParameter("@Nome", cursos.nomeCurso),
                new MySqlParameter("@idCurso", cursos.idCurso));
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        #endregion

    }
}
