using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccBiblioteca.Dados;

namespace TccBiblioteca
{
    public partial class TLAluno : Form
    {
        public TLAluno()
        {
            InitializeComponent();
            formataGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        AlunoDados objAlunoDados = new AlunoDados();
        Aluno ObjAluno = new Aluno();

        #region Formata Grid
        private void formataGridView()  // método criado
        {
            if (dtgAlunos.ColumnCount > 0)
            {
                //altera a cor das linhas do grid
                dtgAlunos.RowsDefaultCellStyle.BackColor = Color.LightBlue;

                //seleciona a linha inteira
                dtgAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //não permite seleção de multiplas linhas
                dtgAlunos.MultiSelect = false;

                // exibe nulos formatados
                dtgAlunos.DefaultCellStyle.NullValue = " - ";

                //permite que o texto maior que célula não seja truncado
                dtgAlunos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        #endregion

        private void FConsultar()
        {
            List<Aluno> tblAlunos = objAlunoDados.listarAlunos();

            dtgAlunos.Rows.Clear();

            if (tblAlunos.Count > 0) // verifica se o select do consultar trouxe registros
            {
                foreach (Aluno aluno in tblAlunos)
                {
                    dtgAlunos.Rows.Add(aluno.rm, aluno.Nome, aluno.curso.nomeCurso, aluno.modulo, aluno.periodo, aluno.Telefone, aluno.Email);
                }
            }
            else
            {
                MessageBox.Show("Não há registros no banco!");
                dtgAlunos.Columns.Clear(); // limpa o GRID para que as colunas não apareçam
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CadastroAluno cAluno = new CadastroAluno();
            cAluno.ShowDialog();
            
        }

        private void TLAluno_Load(object sender, EventArgs e)
        {
            FConsultar();
            formataGridView();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dtgAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string rm = dtgAlunos.SelectedRows[0].Cells[0].Value.ToString();
                ObjAluno = objAlunoDados.consultarAluno(rm);
                CadastroAluno ca = new CadastroAluno(ObjAluno);
                ca.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                string rm = dtgAlunos.SelectedRows[0].Cells[0].Value.ToString();
                ObjAluno = objAlunoDados.consultarAluno(rm);
                CadastroAluno ca = new CadastroAluno(ObjAluno);
                ca.ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string rm = dtgAlunos.SelectedRows[0].Cells[0].Value.ToString();
            ObjAluno = objAlunoDados.excluirAluno(rm);
            formataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FConsultar();
            formataGridView();
        }

        private bool verificar_Nome()
        {

            if (txtNome.Text == "") 
            {
                return false;
            }
            else
                return true;
        }

        private bool verificar_RM()
        {

            if (txtRm.Text == " ")
            {
                return false;
            }
            else
                return true;
        }

        private void txtRm_KeyUp(object sender, KeyEventArgs e)
        {
            if (verificar_RM() == true)
            {

                List<Aluno> tblAlunos = objAlunoDados.consultarAlunoRm(txtRm.Text);

                dtgAlunos.Rows.Clear();

                if (tblAlunos.Count > 0) // verifica se o select do consultar trouxe registros
               {
                    foreach (Aluno aluno in tblAlunos)
                    {
                        dtgAlunos.Rows.Add(aluno.rm, aluno.Nome, aluno.curso.nomeCurso, aluno.modulo, aluno.periodo, aluno.Telefone, aluno.Email);
                    }
                    lblRm.Visible = false;
                }
                else
                {
                    lblRm.Visible = true;
                }
            }
            else
            {
                FConsultar();
                
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (verificar_Nome() == true)
            {

                List<Aluno> tblAlunos = objAlunoDados.consultarAlunoNome(txtNome.Text);

                dtgAlunos.Rows.Clear();

                if (tblAlunos.Count > 0) // verifica se o select do consultar trouxe registros
                {
                    foreach (Aluno aluno in tblAlunos)
                    {
                        dtgAlunos.Rows.Add(aluno.rm, aluno.Nome, aluno.curso.nomeCurso, aluno.modulo, aluno.periodo, aluno.Telefone, aluno.Email);
                    }

                    lblNome.Visible = false;
                }
                else
                {
                    lblNome.Visible = true;
                }
            }
            else
            {
                FConsultar();
                lblNome.Visible = false;
            }
        }

        private void txtRm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) &&  // ! IsNumber--> se a tecla pressionada NAO for um número 
                !(e.KeyChar == (char)Keys.Back) &&  // tecla backspace
                !(e.KeyChar == (char)Keys.Space)) // tecla de espaco
            {
                e.Handled = true;
            }

        }

        private void mensagemErro(string campo)
        {
            lblRm.Text = "Preencha o campo " + campo + " corretamente!";
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  // ! IsLetter--> se a tecla pressionada NAO for uma letra
                !(e.KeyChar == (char)Keys.Back) &&
                !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }

        }

    }
}
