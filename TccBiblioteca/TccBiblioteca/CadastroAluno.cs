using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccBiblioteca.Dados;
using ModuloBiometria;

namespace TccBiblioteca
{
    public partial class CadastroAluno : Form
    {
        private AlunoDados objAlunoDados = new AlunoDados();
        private Aluno ObjAluno = new Aluno();
        private Biometria biometria;
        private bool atualizar = false;

        public CadastroAluno()
        {
            InicializarFormulario();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public CadastroAluno(Aluno aluno)
        {
            InicializarFormulario();
            PopularAluno(aluno);
            atualizar = true;
            Text = "Alterar Cadastro";
            btnDigital.Enabled = false;
            txtRm.Enabled = false;
            // Mudar o tool do botao
        }

        private void PopularAluno(Aluno aluno)
        {
            txtRm.Text = aluno.rm;
            ObjAluno.Digitais = aluno.Digitais;
            txtNome.Text = aluno.Nome;
            txtTelefone.Text = aluno.Telefone;
            txtEmail.Text = aluno.Email;
            //cboCurso.SelectedIndex = cboCurso.Items.IndexOf(aluno.curso.nomeCurso);
            //aluno.curso.nomeCurso;
            //curso
            cboModulo.SelectedIndex = int.Parse(aluno.modulo) - 1;
            cboPeriodoCadastro.SelectedItem = aluno.periodo;
            
            
        }

        private void InicializarFormulario()
        {
            InitializeComponent();
            PopularCursos();
            biometria = new Biometria();
        }

        private void PopularCursos()
        {
            cboCurso.DataSource = objAlunoDados.consultaCurso(ObjAluno);

            //texto exibido no combobox 
            cboCurso.DisplayMember = "nome";

            //valor do item do combobox
            cboCurso.ValueMember = "idCurso";

            cboCurso.Enabled = true;
        }


        private bool preencher_ALUNO()
        {
            ObjAluno.Nome = txtNome.Text;
            ObjAluno.rm = txtRm.Text;
            ObjAluno.Telefone = txtTelefone.Text;
            ObjAluno.Email = txtEmail.Text;
            ObjAluno.periodo = cboPeriodoCadastro.Text;
            ObjAluno.modulo = cboModulo.Text;
            ObjAluno.idCurso = int.Parse(cboCurso.SelectedValue.ToString());

            return true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (cboModulo.SelectedIndex >= 0 && txtNome.Text.Trim() != ""
                 && txtRm.Text.Trim() != "" && cboCurso.SelectedIndex >= 0
                 && cboPeriodoCadastro.SelectedIndex >= 0)
            {
                try
                {
                    preencher_ALUNO();

                    if (atualizar)
                    {
                        if (objAlunoDados.atualizar(ObjAluno))
                            this.Close();
                    }
                    else
                    {
                        if (objAlunoDados.incluir(ObjAluno))
                            LimparFormulario();
                    }
                }
                catch (Exception)
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show("Clicar no botão digital para cadastrar a mesma!", "Cadastro", botao, MessageBoxIcon.Error);

                    //MessageBox.Show("Clicar no botão digital para cadastrar a mesma!");
                }
            }
            else
            {
                MessageBoxButtons botao = MessageBoxButtons.OK;
                DialogResult resultado = MessageBox.Show("Preencha os campos corretamente!", "Cadastro", botao, MessageBoxIcon.Error);
                //MessageBox.Show("Preencha os campos corretamente!");
            }
                
        }

        private void LimparFormulario()
        {
            txtEmail.Text = "";
            cboModulo.SelectedIndex = -1;
            txtNome.Text = "";
            txtRm.Text = "";
            txtTelefone.Text = "";
            cboCurso.SelectedIndex = -1;
            cboPeriodoCadastro.SelectedIndex = -1;
            txtNome.Focus();
        }

        private void btnDigital_Click(object sender, EventArgs e)
        {
            ObjAluno.Digitais = biometria.CapturarDigitaisParaInscricao();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  // ! IsLetter--> se a tecla pressionada NAO for uma letra
                !(e.KeyChar == (char)Keys.Back) &&
                !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;

                mensagemErro("Nome");
            }
            else
            {
                lblMensagem.Text = "";   
            }

        }

        private void mensagemErro(string campo)
        {
         
            lblMensagem.Text = "Preencha o campo " + campo + " corretamente!";
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) &&  // ! IsNumber--> se a tecla pressionada NAO for um número 
                !(e.KeyChar == (char)Keys.Back) &&  // tecla backspace
                !(e.KeyChar == (char)Keys.Space)) // tecla de espaco
            {
                e.Handled = true;

                mensagemErro("Telefone");
            }
            else
            {
                lblMensagem.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (atualizar)
            {
                MessageBoxButtons botao = MessageBoxButtons.YesNo; // Cria os botões sim e não

                DialogResult resultado = MessageBox.Show("Deseja sair sem fazer alteração?", " Alterar Cadastro ", botao, MessageBoxIcon.Warning); // DialogResult é quando eu clico no botão, MessageBoxIcon é para aparecer o icone que vc escolher, nesse caso o Warning

                if (resultado == DialogResult.Yes)  // se eu clicar em sim ele fecha a aplicação, se clicar em não ele fecha o messageBox e mantém a aplicação, sem precisar fazer um else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            this.DialogResult = DialogResult.Cancel;
        }

        

    }
}
