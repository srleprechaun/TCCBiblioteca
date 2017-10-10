namespace TccBiblioteca
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarCursoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMotivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarRelatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.atualizador = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblRelogio = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.AllowUserToDeleteRows = false;
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Rm,
            this.Nome,
            this.Curso,
            this.Modulo,
            this.Periodo,
            this.Motivo});
            this.dtgLista.Location = new System.Drawing.Point(35, 55);
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.Size = new System.Drawing.Size(875, 420);
            this.dtgLista.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "dataentrada";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Rm
            // 
            this.Rm.DataPropertyName = "rm";
            this.Rm.HeaderText = "RM";
            this.Rm.Name = "Rm";
            this.Rm.ReadOnly = true;
            this.Rm.Width = 65;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "aluno";
            this.Nome.HeaderText = "Aluno";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 220;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 130;
            // 
            // Modulo
            // 
            this.Modulo.DataPropertyName = "modulo";
            this.Modulo.HeaderText = "Módulo";
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
            this.Modulo.Width = 50;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "periodo";
            this.Periodo.HeaderText = "Período";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Width = 50;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 217;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.pesquisarToolStripMenuItem1,
            this.funcionarioToolStripMenuItem1,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem1,
            this.cursoToolStripMenuItem2,
            this.moduloToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem1
            // 
            this.alunoToolStripMenuItem1.Name = "alunoToolStripMenuItem1";
            this.alunoToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.alunoToolStripMenuItem1.Text = "Aluno";
            this.alunoToolStripMenuItem1.Click += new System.EventHandler(this.alunoToolStripMenuItem1_Click);
            // 
            // cursoToolStripMenuItem2
            // 
            this.cursoToolStripMenuItem2.Name = "cursoToolStripMenuItem2";
            this.cursoToolStripMenuItem2.Size = new System.Drawing.Size(135, 26);
            this.cursoToolStripMenuItem2.Text = "Curso";
            this.cursoToolStripMenuItem2.Click += new System.EventHandler(this.cursoToolStripMenuItem2_Click);
            // 
            // moduloToolStripMenuItem
            // 
            this.moduloToolStripMenuItem.Name = "moduloToolStripMenuItem";
            this.moduloToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.moduloToolStripMenuItem.Text = "Motivo";
            this.moduloToolStripMenuItem.Click += new System.EventHandler(this.moduloToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem2});
            this.pesquisarToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(95, 25);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
            // 
            // alunoToolStripMenuItem2
            // 
            this.alunoToolStripMenuItem2.Name = "alunoToolStripMenuItem2";
            this.alunoToolStripMenuItem2.Size = new System.Drawing.Size(126, 26);
            this.alunoToolStripMenuItem2.Text = "Aluno";
            this.alunoToolStripMenuItem2.Click += new System.EventHandler(this.alunoToolStripMenuItem2_Click);
            // 
            // funcionarioToolStripMenuItem1
            // 
            this.funcionarioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarCadastroToolStripMenuItem,
            this.cadastroFuncionarioToolStripMenuItem,
            this.funcionárioCadastradosToolStripMenuItem});
            this.funcionarioToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            this.funcionarioToolStripMenuItem1.Size = new System.Drawing.Size(113, 25);
            this.funcionarioToolStripMenuItem1.Text = "Funcionário";
            // 
            // alterarCadastroToolStripMenuItem
            // 
            this.alterarCadastroToolStripMenuItem.Name = "alterarCadastroToolStripMenuItem";
            this.alterarCadastroToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.alterarCadastroToolStripMenuItem.Text = "Alterar Cadastro";
            this.alterarCadastroToolStripMenuItem.Click += new System.EventHandler(this.alterarCadastroToolStripMenuItem_Click);
            // 
            // cadastroFuncionarioToolStripMenuItem
            // 
            this.cadastroFuncionarioToolStripMenuItem.Name = "cadastroFuncionarioToolStripMenuItem";
            this.cadastroFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.cadastroFuncionarioToolStripMenuItem.Text = "Cadastro Funcionário";
            this.cadastroFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroFuncionarioToolStripMenuItem_Click);
            // 
            // funcionárioCadastradosToolStripMenuItem
            // 
            this.funcionárioCadastradosToolStripMenuItem.Name = "funcionárioCadastradosToolStripMenuItem";
            this.funcionárioCadastradosToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.funcionárioCadastradosToolStripMenuItem.Text = "Funcionários Cadastrados";
            this.funcionárioCadastradosToolStripMenuItem.Visible = false;
            this.funcionárioCadastradosToolStripMenuItem.Click += new System.EventHandler(this.funcionárioCadastradosToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem1,
            this.cadastarCursoToolStripMenuItem2,
            this.cadastrarMotivoToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cadastrarAlunoToolStripMenuItem1
            // 
            this.cadastrarAlunoToolStripMenuItem1.Name = "cadastrarAlunoToolStripMenuItem1";
            this.cadastrarAlunoToolStripMenuItem1.Size = new System.Drawing.Size(160, 24);
            this.cadastrarAlunoToolStripMenuItem1.Text = "Aluno";
            this.cadastrarAlunoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem1_Click);
            // 
            // cadastarCursoToolStripMenuItem2
            // 
            this.cadastarCursoToolStripMenuItem2.Name = "cadastarCursoToolStripMenuItem2";
            this.cadastarCursoToolStripMenuItem2.Size = new System.Drawing.Size(160, 24);
            this.cadastarCursoToolStripMenuItem2.Text = "Curso";
            this.cadastarCursoToolStripMenuItem2.Click += new System.EventHandler(this.cadastarCursoToolStripMenuItem2_Click);
            // 
            // cadastrarMotivoToolStripMenuItem
            // 
            this.cadastrarMotivoToolStripMenuItem.Name = "cadastrarMotivoToolStripMenuItem";
            this.cadastrarMotivoToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.cadastrarMotivoToolStripMenuItem.Text = "Motivo";
            this.cadastrarMotivoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMotivoToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.cursoToolStripMenuItem1});
            this.pesquisarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.cursoToolStripMenuItem.Text = "Motivo Visita";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem1
            // 
            this.cursoToolStripMenuItem1.Name = "cursoToolStripMenuItem1";
            this.cursoToolStripMenuItem1.Size = new System.Drawing.Size(171, 24);
            this.cursoToolStripMenuItem1.Text = "Curso";
            this.cursoToolStripMenuItem1.Click += new System.EventHandler(this.cursoToolStripMenuItem1_Click);
            // 
            // alterarRelatorioToolStripMenuItem
            // 
            this.alterarRelatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem});
            this.alterarRelatorioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.alterarRelatorioToolStripMenuItem.Name = "alterarRelatorioToolStripMenuItem";
            this.alterarRelatorioToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.alterarRelatorioToolStripMenuItem.Text = "Relatório";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::TccBiblioteca.Properties.Resources.business_user_delete;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(931, 444);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 60);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // atualizador
            // 
            this.atualizador.Interval = 1000;
            this.atualizador.Tick += new System.EventHandler(this.atualizador_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRelogio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1045, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblRelogio
            // 
            this.lblRelogio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblRelogio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(89, 22);
            this.lblRelogio.Text = "lblRelogio";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 530);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgLista);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarRelatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastarCursoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMotivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem moduloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.Timer atualizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblRelogio;
    }
}

