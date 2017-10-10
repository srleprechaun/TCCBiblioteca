using System;
using System.Collections.Generic;
using TccBiblioteca.Classes;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace TccBiblioteca.Dados
{
    public class MotivoVisitaDados
    {
        DadosMySQL dados = new DadosMySQL();
        
        #region Cadastrar
          public void Incluir(MotivoVisita motivosVisita) {
            try
            {
                string sql = "insert into MotivoVisita (descricao, idExcluir) values (@Descricao, 1)";
                dados.ConvertSqlToInt(sql, new MySqlParameter("@Descricao", motivosVisita.descricao));
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Consultar
        public DataTable consultar()
        {
            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                "SELECT Descricao, id FROM MotivoVisita where idExcluir = 1 ");

            return tblRecuperada;
        }
        #endregion

        #region EXCLUISAO LOGICA
        public void Excluir(MotivoVisita motivosVisita)
        {
            try
            {
                string sql = "UPDATE motivoVisita SET Descricao = @Descricao, idExcluir = 0 where @Id = id ";
                dados.ConvertSqlToInt(sql, new MySqlParameter("@Descricao", motivosVisita.descricao),
                new MySqlParameter("@Id", motivosVisita.idMotivoVisita));
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        #endregion

        #region ListarMotivos
        public List<MotivoVisita> consultarMotivoVisita()
        {
            List<MotivoVisita> motivos = new List<MotivoVisita>();
            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                "SELECT DESCRICAO, ID FROM MotivoVisita where idExcluir = 1");

            for (int i = 0; i < tblRecuperada.Rows.Count; i++)
            {
                MotivoVisita motivo = new MotivoVisita();
                motivo.idMotivoVisita = Convert.ToInt32(tblRecuperada.Rows[i]["ID"]);
                motivo.descricao = tblRecuperada.Rows[i]["DESCRICAO"].ToString();

                motivos.Add(motivo);
            }


            return motivos;
        }
        #endregion

        #region Pesquisar Motivo Repetido
        public bool PesquisarMotivoRep(string descricao)
        {
            try
            {
                string sql = "Select descricao from MotivoVisita where descricao = @descricao and idExcluir = 1  ";


                if (dados.ConvertSqlToDataTable(sql, new MySqlParameter("@Descricao", descricao)).Rows.Count > 0)
                    return true;

                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;

        }
        #endregion


    }
}
