using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccBiblioteca.Classes;
using TccBiblioteca.Dados;

namespace TccBiblioteca
{
    public partial class Login : Form
    {
        DadosMySQL dados = new DadosMySQL();

        FuncionarioDados funcionarioDados = new FuncionarioDados();
        public Funcionario funcionario { get; set; }
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.No;
            if (txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                try
                {
                    string login =txtUsuario.Text;
                    string senha = txtSenha.Text;

                    Funcionario funcionarioAutenticado = funcionarioDados.autenticar(login, senha);

                    if (funcionarioAutenticado != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        funcionario = funcionarioAutenticado;
                    }
                    else
                    {
                        MessageBoxButtons botao = MessageBoxButtons.OK;
                        DialogResult resultado = MessageBox.Show(" Usuário ou senha inválidos! ", "Login", botao, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else{

                MessageBoxButtons botao = MessageBoxButtons.OK;
                DialogResult resultado = MessageBox.Show(" Campos em branco! ", "Login", botao, MessageBoxIcon.Error);

            }
        }

        //private void Login_Load(object sender, EventArgs e)
        //{
        //    txtSenha.Text = "123";
        //    txtUsuario.Text = "123";
        //}

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
