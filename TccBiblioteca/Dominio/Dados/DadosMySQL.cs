using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace TccBiblioteca.Dados
{
    public class DadosMySQL
    {
        #region Variáveis
        /// <summary>
        /// Objeto que mantém a conexão com o banco.
        /// </summary>

        private MySqlConnection objConexao = null;

        #endregion

        #region Métodos

        #region Métodos Privados
        #region Conectar()
        /// <summary>
        /// Inicia uma conexão com o banco de dados.
        /// </summary>
        private void Conectar()
        {
            // Carrega a string de conexão
            string strStringConexao = @"Server=localhost;Database=bdbiblioteca;Uid=root;";

            // Cria uma conexão com o banco de dados.
            objConexao = new MySqlConnection(strStringConexao);

            // Abre a conexão.
            objConexao.Open();
        }
        #endregion

        #region Desconectar()
        /// <summary>
        /// Fecha a conexão com o banco de dados.
        /// </summary>
        private void Desconectar()
        {
            // Fecha a conexão.
            objConexao.Close();
        }

        #endregion
        #endregion

        #region Métodos Públicos
        #region ConvertSqlToDataTable(string)
        ///// <summary>
        ///// Executa um comando SQL e retorna um
        ///// DataTable preenchido com o resultado
        ///// da pesquisa.
        ///// </summary>
        ///// <param name="p_strComandoSQL">
        ///// String contendo o comando SQL a ser executado.
        ///// </param>
        ///// <returns>
        ///// DataTable com o resultado da consulta.
        ///// </returns>
        public DataTable ConvertSqlToDataTable(string p_strComandoSQL)
        {
            // Executa o comando SQL sem passar parâmetros.
            return ConvertSqlToDataTable(p_strComandoSQL, null);
        }
        #endregion

        #region ConvertSqlToDataTable(string, SqlParameter[])
        ///// <summary>
        ///// Executa um comando SQL e retorna um
        ///// DataTable preenchido com o resultado
        ///// da pesquisa.
        ///// </summary>
        ///// <param name="p_strComandoSQL">
        ///// String contendo o comando SQL a ser executado.
        ///// </param>
        ///// <param name="p_arrParametros">
        ///// Coleção de parâmetros utilizados pelo comando SQL.
        ///// </param>
        ///// <returns>
        ///// DataTable com o resultado da consulta.
        ///// </returns>
        public DataTable ConvertSqlToDataTable(string p_strComandoSQL,
            params MySqlParameter[] p_arrParametros)
        {
            // Conecta ao banco.
            Conectar();

            // Instancia um DataTable de resultado.
            DataTable tblResultado = new DataTable();

            try
            {
                #region Cria comando SQL

                // Instancia um comando SQL a ser executado.
                MySqlCommand objComandoSQL = new MySqlCommand();

                objComandoSQL.Connection = objConexao;
                objComandoSQL.CommandText = p_strComandoSQL;
                #endregion

                #region Adiciona parâmetros ao comando
                // Verifica se existem parâmetros.
                if (p_arrParametros != null)
                {
                    // Percorre cada parâmetro recebido.
                    foreach (MySqlParameter objParametro
                        in p_arrParametros)
                    {
                        // Adiciona ao comando SQL.
                        objComandoSQL.Parameters.Add(
                            objParametro);
                    }
                }
                #endregion

                #region Executa o comando SQL

                // Define o adaptador de comando Select.
                MySqlDataAdapter objAdaptador =
                    new MySqlDataAdapter();

                objAdaptador.SelectCommand = objComandoSQL;

                // Preenche o resultado executando o comando.
                objAdaptador.Fill(tblResultado);

                #endregion
            }
            finally
            {
                // Fecha a conexão.
                Desconectar();
            }

            // Retorna o resultado.
            return tblResultado;
        }
        #endregion

        #region ConvertSqlToInt(string, SqlParameter[])
        /// <summary>
        /// Executa um comando SQL e retorna o
        /// número de linhas afetadas.
        /// </summary>
        /// <param name="p_strComandoSQL">
        /// String contendo o comando SQL a ser executado.
        /// </param>
        /// <param name="p_arrParametros">
        /// Coleção de parâmetros utilizados pelo comando SQL.
        /// </param>
        /// <returns>
        /// Número de linhas afetadas pelo comando.
        /// </returns>
        public int ConvertSqlToInt(string p_strComandoSQL,
            params MySqlParameter[] p_arrParametros)
        {
            // Conecta ao banco.
            Conectar();

            // Cria variável para armazenar as linhas afetadas.
            int intLinhasAfetadas = 0;

            try
            {
                #region Cria comando SQL

                // Instancia um comando SQL a ser executado.
                MySqlCommand objComandoSQL = new MySqlCommand();

                objComandoSQL.Connection = objConexao;
                objComandoSQL.CommandText = p_strComandoSQL;

                #endregion

                #region Adiciona parâmetros ao comando
                // Verifica se existem parâmetros.
                if (p_arrParametros != null)
                {
                    // Percorre cada parâmetro recebido.
                    foreach (MySqlParameter objParametro
                        in p_arrParametros)
                    {
                        // Adiciona ao comando SQL.
                        objComandoSQL.Parameters.Add(
                            objParametro);
                    }
                }
                #endregion

                #region Executa o comando SQL
                // Executa o comando.
                int LinhasAfetadas = objComandoSQL.
                    ExecuteNonQuery();
                #endregion
            }
            finally
            {
                // Fecha a conexão.
                Desconectar();
            }

            // Retorna o número de linhas afetadas.
            return intLinhasAfetadas;
        }
        #endregion
        #endregion

        #endregion
    }
}
