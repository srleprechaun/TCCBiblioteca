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
    public partial class FuncionariosCadastrados : Form
    {
        public FuncionariosCadastrados()
        {
            InitializeComponent();
            FConsultar();
            this.StartPosition = FormStartPosition.CenterScreen;
            formataGridView();
        }

        FuncionarioDados objFuncionarioDados = new FuncionarioDados();
        Funcionario objFuncionario = new Funcionario();

        #region Formata Grid


        private void formataGridView()  // método criado
        {
            if (dtgFuncionariosCadastrados.ColumnCount > 0)
            {
                //altera a cor das linhas do grid
                dtgFuncionariosCadastrados.RowsDefaultCellStyle.BackColor = Color.Aquamarine;

                //seleciona a linha inteira
                dtgFuncionariosCadastrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //não permite seleção de multiplas linhas
                dtgFuncionariosCadastrados.MultiSelect = false;

                // exibe nulos formatados
                dtgFuncionariosCadastrados.DefaultCellStyle.NullValue = " - ";

                //permite que o texto maior que célula não seja truncado
                dtgFuncionariosCadastrados.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }


        #endregion

        private void FConsultar()
        {
            List<Funcionario> tblFuncionarios = objFuncionarioDados.listarFuncionario();

            dtgFuncionariosCadastrados.Rows.Clear();

            if (tblFuncionarios.Count > 0) // verifica se o select do consultar trouxe registros
            {
                foreach (Funcionario funcionario in tblFuncionarios)
                {
                    dtgFuncionariosCadastrados.Rows.Add(funcionario.id, funcionario.Nome,  funcionario.Senha, funcionario.Login , funcionario.Telefone);
                    dtgFuncionariosCadastrados.Rows[0].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Não há registros no banco!");
                //dtgFuncionariosCadastrados.Columns.Clear(); // limpa o GRID para que as colunas não apareçam
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id = dtgFuncionariosCadastrados.SelectedRows[0].Cells[0].Value.ToString();
            //objFuncionario = objFuncionarioDados.
            FuncionarioAlterarCadastro ca = new FuncionarioAlterarCadastro(objFuncionario);
            ca.ShowDialog();
        }

        private void txtDeletar_Click(object sender, EventArgs e)
        {
            objFuncionario.id = int.Parse(dtgFuncionariosCadastrados.CurrentRow.Cells["id"].Value.ToString());
            objFuncionario.Login = dtgFuncionariosCadastrados.CurrentRow.Cells["login"].Value.ToString();
            objFuncionario.Nome = dtgFuncionariosCadastrados.CurrentRow.Cells["nome"].Value.ToString();
            objFuncionario.Senha = dtgFuncionariosCadastrados.CurrentRow.Cells["senha"].Value.ToString();
            objFuncionario.Telefone = dtgFuncionariosCadastrados.CurrentRow.Cells["telefone"].Value.ToString();

            try
            {
                DialogResult deletar = MessageBox.Show("Deseja excluir esse registro?",
                    "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deletar == DialogResult.Yes)
                {
                    objFuncionarioDados.Excluir(objFuncionario);
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
