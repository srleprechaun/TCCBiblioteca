namespace TccBiblioteca
{
    partial class TLCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLCurso));
            this.dtGridCurso = new System.Windows.Forms.DataGridView();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExcluir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridCurso
            // 
            this.dtGridCurso.AllowUserToAddRows = false;
            this.dtGridCurso.AllowUserToDeleteRows = false;
            this.dtGridCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCurso,
            this.Nome,
            this.idExcluir});
            this.dtGridCurso.Location = new System.Drawing.Point(34, 83);
            this.dtGridCurso.Name = "dtGridCurso";
            this.dtGridCurso.ReadOnly = true;
            this.dtGridCurso.Size = new System.Drawing.Size(339, 234);
            this.dtGridCurso.TabIndex = 11;
            // 
            // idCurso
            // 
            this.idCurso.DataPropertyName = "idCurso";
            this.idCurso.HeaderText = "id";
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            this.idCurso.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 296;
            // 
            // idExcluir
            // 
            this.idExcluir.DataPropertyName = "idExcluir";
            this.idExcluir.HeaderText = "idExcluir";
            this.idExcluir.Name = "idExcluir";
            this.idExcluir.ReadOnly = true;
            this.idExcluir.Visible = false;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(34, 40);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(214, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Curso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::TccBiblioteca.Properties.Resources.delete;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(289, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 60);
            this.btnCancelar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCancelar, "Sair");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::TccBiblioteca.Properties.Resources.notes_add;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrar.Location = new System.Drawing.Point(289, 9);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(84, 60);
            this.btnCadastrar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCadastrar, "Cadastrar");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::TccBiblioteca.Properties.Resources.notes_delete;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Location = new System.Drawing.Point(34, 323);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(84, 60);
            this.btnExcluir.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnExcluir, "Sair");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // TLCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 397);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtGridCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TLCurso";
            this.Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridCurso;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExcluir;
        private System.Windows.Forms.Button btnExcluir;
    }
}