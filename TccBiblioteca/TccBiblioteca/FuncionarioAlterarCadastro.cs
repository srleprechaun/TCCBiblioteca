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
    public partial class FuncionarioAlterarCadastro : Form
    {

        private FuncionarioDados objFD = new FuncionarioDados();

        Funcionario ObjFuncionario;

        public FuncionarioAlterarCadastro(Funcionario funcionario)
        {
            InitializeComponent();
            ObjFuncionario = funcionario;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PopularTela()
        {
            txtNome.Text = ObjFuncionario.Nome;
            txtTelefone.Text = ObjFuncionario.Telefone;
            txtLogin.Text = ObjFuncionario.Login;
        }

        private void PopularCampos()
        {
            ObjFuncionario.Nome = txtNome.Text;
            ObjFuncionario.Telefone = txtTelefone.Text;
            ObjFuncionario.Login = txtLogin.Text;
            ObjFuncionario.Senha = txtConfirmarSenha.Text;
        }

        private void FuncionarioAlterarCadastro_Load(object sender, EventArgs e)
        {
            PopularTela();
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
        }

        private void txtSalvar_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text != string.Empty && txtConfirmarSenha.Text != string.Empty && txtSenhaAntiga.Text != string.Empty )
            {
                if (ObjFuncionario.Senha == txtSenhaAntiga.Text)
                {
                    if (txtNovaSenha.Text == txtConfirmarSenha.Text)
                    {
                        try
                        {
                            PopularCampos();
                            objFD.AlterarCadastro(ObjFuncionario);
                            MessageBoxButtons botao = MessageBoxButtons.OK;
                            DialogResult resultado = MessageBox.Show("Cadastro Alterado", "Alterar Cadastro", botao, MessageBoxIcon.Information);
                            this.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBoxButtons botao = MessageBoxButtons.OK;
                        DialogResult resultado = MessageBox.Show(" Senhas não são iguais ", " Alterar Cadastro ", botao, MessageBoxIcon.Error);
                    }

                }

                else
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Senha antiga não é válida. ", " Alterar Cadastro ", botao, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBoxButtons botao = MessageBoxButtons.OK;
                DialogResult resultado = MessageBox.Show(" Campos em branco. ", "Alterar Cadastro", botao, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
