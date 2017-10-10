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
    public partial class TelaPrincipal : Form
    {
        Funcionario _funcionario;

        VisitaDados visitaDados = new VisitaDados();
        
        bool _oUsuarioEAdministrador = false;

        public TelaPrincipal(Funcionario funcionario)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            formataGridView();

            dtgLista.AutoGenerateColumns = false;

            _funcionario = funcionario;

            if(funcionario.id == 1)
                _oUsuarioEAdministrador = true;

            atualizador.Start();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            cadastroFuncionarioToolStripMenuItem.Visible = _oUsuarioEAdministrador;
            funcionárioCadastradosToolStripMenuItem.Visible = _oUsuarioEAdministrador;
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioAlterarCadastro funcionarioAlterarCadastro = new FuncionarioAlterarCadastro(_funcionario);
            funcionarioAlterarCadastro.ShowDialog();
        }

        private void cadastrarAlunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno();
            cadastroAluno.ShowDialog();
        }

        private void cadastrarMotivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TLMotivoVisita motivoVisita = new TLMotivoVisita();
            motivoVisita.ShowDialog();
        }

        private void cadastarCursoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TLCurso cadastroCurso = new TLCurso();
            cadastroCurso.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cad = new CadastroFuncionario();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TLAluno AlunosCadastrados = new TLAluno();
            AlunosCadastrados.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TLMotivoVisita MotivoVisitasCadastrados = new TLMotivoVisita();
            MotivoVisitasCadastrados.ShowDialog();
        }

        private void cursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            TLCurso CursosCadastrados = new TLCurso();
            CursosCadastrados.ShowDialog();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroAluno TelaCadastroAluno = new CadastroAluno();
            TelaCadastroAluno.ShowDialog();
        }

        private void cursoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TLCurso telaCurso = new TLCurso();
            telaCurso.ShowDialog();
        }

        private void moduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TLMotivoVisita telaMotivoVisita = new TLMotivoVisita();
            telaMotivoVisita.ShowDialog();
        }


        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TLAluno telaAluno = new TLAluno();
            telaAluno.ShowDialog();
        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioAlterarCadastro TelaFaCadastro = new FuncionarioAlterarCadastro(_funcionario);
            TelaFaCadastro.ShowDialog();
        }

        private void cadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cFuncionario = new CadastroFuncionario();
            cFuncionario.ShowDialog();
        }

        private void funcionárioCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionariosCadastrados fCadastrados = new FuncionariosCadastrados();
            fCadastrados.ShowDialog();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.ShowDialog();
        }

        private void atualizador_Tick(object sender, EventArgs e)
        {
            dtgLista.DataSource = visitaDados.listar();
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }

        #region Formata Cor Grid
        private void formataGridView()  // método criado
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString();

            if (dtgLista.ColumnCount > 0)
            {
                //altera a cor das linhas do grid
                dtgLista.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

    }
}
