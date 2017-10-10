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
    public partial class TLCurso : Form
    {
        public TLCurso()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            FConsultar();
            formataGridView();
        }

        CursosDados objDados = new CursosDados();
        Curso objCurso = new Curso();

        private void FConsultar()
        {
            DataTable tblDep = objDados.consultar(objCurso);

            if (tblDep.Rows.Count > 0) // verifica se o select do consultar trouxe registros
            {
                dtGridCurso.DataSource = tblDep;
            }
            else
            {
                MessageBox.Show("Não há registros no banco!");
                //dtGridCurso.Columns.Clear(); // limpa o GRID para que as colunas não apareçam
            }
        }

        #region Cadastrar Curso
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (preencher_Curso() == true)
            {
                if (objDados.PesquisarCursoRep(txtCurso.Text) == false)
                {
                    objDados.Incluir(objCurso);
                    FConsultar();
                    txtCurso.Focus();
                    txtCurso.Clear();
                    formataGridView();

                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show("Curso cadastrado com sucesso", "Cadastro Curso", botao, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Curso já cadastrado!", "Cadastro Curso", botao, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region PreencherCURSO

        private bool preencher_Curso()
        {
            objCurso.nomeCurso = txtCurso.Text;

            if (txtCurso.Text == "") // verifica se o campo Curso está vazio
            {
                MessageBoxButtons botao = MessageBoxButtons.OK;
                DialogResult resultado = MessageBox.Show("Preencha o campo!", "Cadastro Curso", botao, MessageBoxIcon.Error);

               // MessageBox.Show("Preencha o campo!");
                return false;
            }
            else
                return true;
        }

        #endregion

       #region Formata Cor Grid
        private void formataGridView()  // método criado
        {
            if (dtGridCurso.ColumnCount > 0)
            {
                //altera a cor das linhas do grid
                dtGridCurso.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        #endregion 

        //private void txtCurso_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (txtCurso.Text.Trim() != "")
        //    {
        //        btnCadastrar.Enabled = true;
        //    }
        //    else
        //        btnCadastrar.Enabled = false;
        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objCurso.idCurso = int.Parse(dtGridCurso.CurrentRow.Cells["idCurso"].Value.ToString());
            objCurso.nomeCurso = dtGridCurso.CurrentRow.Cells["nome"].Value.ToString();

            try
            {
                DialogResult deletar = MessageBox.Show("Deseja excluir esse registro?",
                    "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deletar == DialogResult.Yes)
                {
                    objDados.Excluir(objCurso);
                    FConsultar();
                }
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
