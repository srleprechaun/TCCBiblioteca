using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TccBiblioteca.Dados;
using TccBiblioteca.Classes;

namespace TccBiblioteca
{
    public partial class TLMotivoVisita : Form
    {
        public TLMotivoVisita()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            FConsultar();
            formataGridView();
        }

        MotivoVisitaDados obj = new MotivoVisitaDados();
        MotivoVisita objvisita = new MotivoVisita();


        private void FConsultar() {

            DataTable tblDep = obj.consultar();

            if (tblDep.Rows.Count > 0) // verifica se o select do consultar trouxe registros
            {
                dtGridMotivoVisita.DataSource = tblDep;
            }
            else
            {
                MessageBox.Show("Não há registros no banco!");
                //dtGridMotivoVisita.Columns.Clear(); // limpa o GRID para que as colunas não apareçam
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (preencher_MVISITA() == true)
            {
                if (obj.PesquisarMotivoRep(txtMotivo.Text) == false)
                {
                    obj.Incluir(objvisita);
                    FConsultar();
                    formataGridView();
                    txtMotivo.Clear();
                    txtMotivo.Focus();
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Motivo cadastrado com sucesso! ", "Cadastro Motivo", botao, MessageBoxIcon.Information);
                }

                else 
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Motivo já cadastrado!", "Cadastro Motivo", botao, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FConsultar();
        }

        #region PreencherMOTIVOVISITA

        private bool preencher_MVISITA()
        {
            objvisita.descricao = txtMotivo.Text;

            if (txtMotivo.Text == "") // verifica se o campo nome está vazio
            {
                string mensagem = "Preencha o campo!";
                MessageBoxButtons botao = MessageBoxButtons.OK;
                DialogResult resultado = MessageBox.Show(mensagem, "Cadastro Motivo", botao, MessageBoxIcon.Error);
                //MessageBox.Show("Preencha o campo!");
                txtMotivo.Focus();
                return false;
            }
            else
                return true;
        }
        #endregion

        #region Formata Cor Grid
        private void formataGridView()  // método criado
        {
            if (dtGridMotivoVisita.ColumnCount > 0)
            {
                //altera a cor das linhas do grid
                dtGridMotivoVisita.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        #endregion 
        //private void txtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (txtMotivo.Text.Trim() != "")
        //    {
        //        btnAdicionar.Enabled = true;
        //    }
        //    else
        //        btnAdicionar.Enabled = false;
        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            objvisita.idMotivoVisita = int.Parse(dtGridMotivoVisita.CurrentRow.Cells[1].Value.ToString());
            objvisita.descricao = dtGridMotivoVisita.CurrentRow.Cells["mVisita"].Value.ToString();

            try
            {
                DialogResult deletar = MessageBox.Show("Deseja excluir esse registro?",
                    "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deletar == DialogResult.Yes)
                {
                    obj.Excluir(objvisita);
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
