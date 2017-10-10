using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TccBiblioteca.Classes;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using TccBiblioteca.Dados;

namespace TccBiblioteca.Dados
{
    public class VisitaDados
    {
        DadosMySQL dados = new DadosMySQL();

        #region InsertVisita
        public void InsertVisita(Visita visita)
        {
            try
            {
                string sql = "insert into Visita (DataEntrada, Aluno_RM, MotivoVisita_ID)" +
                    " values (@DataEntrada, @AlunoRM, @MotivoID)";

                dados.ConvertSqlToInt(sql, new MySqlParameter("@DataEntrada", DateTime.Now),
                  new MySqlParameter("@AlunoRM", visita.AlunoRM),
                  new MySqlParameter("@MotivoID", visita.MotivoVisitaId));
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region listar Alunos Para Validacao De Digital
        public DataTable listar()
        {
            string sql = "select v.dataentrada, a.rm, a.nome as \"aluno\", a.periodo, a.modulo, mv.descricao as \"motivo\", c.nome as \"curso\" " + 
                         "from visita v " +
                         "inner join aluno a on a.rm = v.aluno_rm " +
                         "inner join motivovisita mv on mv.id = v.motivovisita_id " +
                         "inner join aluno_has_curso ahc on ahc.aluno_rm = a.rm " +
                         "inner join curso c on c.idcurso = ahc.curso_idcurso " +
                         "order by v.dataentrada desc ";

            return dados.ConvertSqlToDataTable(sql);
            
        }
        #endregion
    }
}
