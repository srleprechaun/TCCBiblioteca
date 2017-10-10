namespace TccBiblioteca
{
    partial class FuncionariosCadastrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionariosCadastrados));
            this.dtgFuncionariosCadastrados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionariosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgFuncionariosCadastrados
            // 
            this.dtgFuncionariosCadastrados.AllowUserToAddRows = false;
            this.dtgFuncionariosCadastrados.AllowUserToDeleteRows = false;
            this.dtgFuncionariosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionariosCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.senha,
            this.login,
            this.Telefone});
            this.dtgFuncionariosCadastrados.Location = new System.Drawing.Point(26, 45);
            this.dtgFuncionariosCadastrados.Name = "dtgFuncionariosCadastrados";
            this.dtgFuncionariosCadastrados.ReadOnly = true;
            this.dtgFuncionariosCadastrados.Size = new System.Drawing.Size(374, 279);
            this.dtgFuncionariosCadastrados.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 175;
            // 
            // senha
            // 
            this.senha.HeaderText = "senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // login
            // 
            this.login.HeaderText = "login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Visible = false;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 156;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::TccBiblioteca.Properties.Resources.delete;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(337, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 52);
            this.btnCancelar.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDeletar
            // 
            this.txtDeletar.BackgroundImage = global::TccBiblioteca.Properties.Resources.business_user_delete;
            this.txtDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtDeletar.Location = new System.Drawing.Point(157, 344);
            this.txtDeletar.Name = "txtDeletar";
            this.txtDeletar.Size = new System.Drawing.Size(84, 52);
            this.txtDeletar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.txtDeletar, "Deletar");
            this.txtDeletar.UseVisualStyleBackColor = true;
            this.txtDeletar.Click += new System.EventHandler(this.txtDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::TccBiblioteca.Properties.Resources.business_user_edit;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(26, 344);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 52);
            this.btnEditar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FuncionariosCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 408);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtgFuncionariosCadastrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncionariosCadastrados";
            this.Text = "Funcionários Cadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionariosCadastrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFuncionariosCadastrados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button txtDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}