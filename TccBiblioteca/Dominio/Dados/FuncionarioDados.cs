using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TccBiblioteca.Classes;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TccBiblioteca.Dados
{
    public class FuncionarioDados
    {

        DadosMySQL dados = new DadosMySQL();

        public void Salvar(Funcionario funcionario)
        {

            string sql = "insert into Funcionario (login,nome,senha,telefone, idExcluir) values (@login,@nome,@senha,@Telefone, 1)";

            dados.ConvertSqlToInt(sql,new MySqlParameter("@login",funcionario.Login),
                new MySqlParameter("@nome",funcionario.Nome),
                new MySqlParameter("@senha",funcionario.Senha),
                new MySqlParameter("@Telefone", funcionario.Telefone));
        }


        public Funcionario autenticar(string login,string senha)
        {
            Funcionario funcionario = null;
            
            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                "SELECT id, nome, telefone, Login, senha from funcionario where Login = @login and senha = @senha and idExcluir = 1",
                new MySqlParameter("@login", login),
                new MySqlParameter("@senha", senha));

            if (tblRecuperada.Rows.Count > 0)
            {
                funcionario = new Funcionario { 
                    id = Convert.ToInt32(tblRecuperada.Rows[0]["id"]),
                    Nome = tblRecuperada.Rows[0]["nome"].ToString(),
                    Telefone = tblRecuperada.Rows[0]["telefone"].ToString(),
                    Login = tblRecuperada.Rows[0]["login"].ToString(),
                    Senha = tblRecuperada.Rows[0]["senha"].ToString()
                };

                
            }

            return funcionario;
        }

        public void AlterarCadastro(Funcionario funcionario) 
        {
            try
            {
                string sql = "UPDATE Funcionario Set login = @login, nome = @nome, senha = @senha, telefone = @telefone" +
                " where id = @id";
                dados.ConvertSqlToInt(sql, new MySqlParameter("@login", funcionario.Login),
                    new MySqlParameter("@nome", funcionario.Nome),
                    new MySqlParameter("@senha", funcionario.Senha),
                    new MySqlParameter("@id", funcionario.id),
                    new MySqlParameter("@Telefone", funcionario.Telefone));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Falha", ex);
            }

        }

        #region Listar Funcionarios
        public List<Funcionario> listarFuncionario()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                  "SELECT F.Nome, F.Telefone, F.login, F.senha, F.Id FROM Funcionario F where idExcluir = 1");

            foreach (DataRow linha in tblRecuperada.Rows)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.Nome = linha["Nome"].ToString();
                funcionario.Telefone = linha["Telefone"].ToString();

                funcionario.Login = linha["login"].ToString();
                funcionario.id = int.Parse(linha["id"].ToString());
                funcionario.Senha = linha["senha"].ToString();

                funcionarios.Add(funcionario); // lista (funcionarios)
            }

            return funcionarios;
        }
        #endregion


        #region EXCLUISAO LOGICA
        public void Excluir(Funcionario funcionario)
        {
            try
            {
                string sql = "UPDATE Funcionario Set idExcluir = 0 " +
                " where id = @id" ;
                dados.ConvertSqlToInt(sql, new MySqlParameter("@id", funcionario.id));
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        #endregion

    }
}
