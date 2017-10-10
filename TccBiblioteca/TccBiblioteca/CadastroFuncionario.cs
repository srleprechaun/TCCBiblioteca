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
    public partial class CadastroFuncionario : Form
    {
        private Funcionario Funcionario{get; set;}
        private FuncionarioDados objFD = new FuncionarioDados();

        public CadastroFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            Funcionario = funcionario;
            this.StartPosition = FormStartPosition.CenterScreen;
            PreencherTela();
        }

        public CadastroFuncionario() : this(new Funcionario()){}

        private void PopularCampos()
        {
            try
            {
                    Funcionario.Nome = txtNome.Text;
                    Funcionario.Telefone = txtTelefone.Text;
                    Funcionario.Login = txtLogin.Text;
                    Funcionario.Senha = txtSenha.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }

        }

        private void PreencherTela()
        {
            txtNome.Text = Funcionario.Nome;
            txtTelefone.Text = Funcionario.Telefone;
            txtLogin.Text = Funcionario.Login;
            txtSenha.Text = Funcionario.Senha;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != string.Empty && txtNome.Text != string.Empty && txtSenha.Text != string.Empty)
              {

                try
                {
                    PopularCampos();
                    objFD.Salvar(Funcionario);
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Funcionário cadastrado com sucesso. ", "Cadastro Funcionário", botao, MessageBoxIcon.Information);
                    txtNome.Text = "";
                    txtTelefone.Text = "";
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    txtNome.Focus();
                }
                catch (Exception)
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Usuário já cadastrado. ", "Cadastro Funcionário", botao, MessageBoxIcon.Error);
                }
             }
            else 
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Campos em branco. ", "Cadastro Funcionário", botao, MessageBoxIcon.Error);
                }
                
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
