namespace Livraria
{
    partial class formAtendente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.funcionario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txtLoginFunc = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridSearchFuncio = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaFunc = new System.Windows.Forms.TextBox();
            this.btnNovoFunc = new System.Windows.Forms.Button();
            this.btnSalvarFunc = new System.Windows.Forms.Button();
            this.btnAlterarFunc = new System.Windows.Forms.Button();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnCancelarFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchFuncio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcionario
            // 
            this.funcionario.AutoSize = true;
            this.funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.funcionario.Location = new System.Drawing.Point(217, 10);
            this.funcionario.Name = "funcionario";
            this.funcionario.Size = new System.Drawing.Size(225, 42);
            this.funcionario.TabIndex = 0;
            this.funcionario.Text = "Funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            this.label1.Visible = false;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.Red;
            this.lbl_codigo.Location = new System.Drawing.Point(118, 84);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(0, 24);
            this.lbl_codigo.TabIndex = 2;
            this.lbl_codigo.Visible = false;
            this.lbl_codigo.Click += new System.EventHandler(this.lbl_codigo_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(38, 167);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(68, 24);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Login:";
            // 
            // txtLoginFunc
            // 
            this.txtLoginFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginFunc.Location = new System.Drawing.Point(122, 162);
            this.txtLoginFunc.MaxLength = 20;
            this.txtLoginFunc.Name = "txtLoginFunc";
            this.txtLoginFunc.Size = new System.Drawing.Size(179, 29);
            this.txtLoginFunc.TabIndex = 4;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(122, 122);
            this.txtNomeFunc.MaxLength = 60;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(278, 29);
            this.txtNomeFunc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFunc.Location = new System.Drawing.Point(122, 204);
            this.txtSenhaFunc.MaxLength = 8;
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(179, 29);
            this.txtSenhaFunc.TabIndex = 8;
            this.txtSenhaFunc.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha:";
            // 
            // gridSearchFuncio
            // 
            this.gridSearchFuncio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchFuncio.Location = new System.Drawing.Point(67, 441);
            this.gridSearchFuncio.Name = "gridSearchFuncio";
            this.gridSearchFuncio.Size = new System.Drawing.Size(537, 153);
            this.gridSearchFuncio.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscaFunc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa Por Funcionário";
            // 
            // txtBuscaFunc
            // 
            this.txtBuscaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFunc.Location = new System.Drawing.Point(19, 47);
            this.txtBuscaFunc.MaxLength = 20;
            this.txtBuscaFunc.Name = "txtBuscaFunc";
            this.txtBuscaFunc.Size = new System.Drawing.Size(394, 29);
            this.txtBuscaFunc.TabIndex = 12;
            this.txtBuscaFunc.TextChanged += new System.EventHandler(this.txtBuscaFunc_TextChanged);
            // 
            // btnNovoFunc
            // 
            this.btnNovoFunc.Location = new System.Drawing.Point(509, 15);
            this.btnNovoFunc.Name = "btnNovoFunc";
            this.btnNovoFunc.Size = new System.Drawing.Size(137, 50);
            this.btnNovoFunc.TabIndex = 12;
            this.btnNovoFunc.Text = "Novo";
            this.btnNovoFunc.UseVisualStyleBackColor = true;
            this.btnNovoFunc.Click += new System.EventHandler(this.btnNovoFunc_Click);
            // 
            // btnSalvarFunc
            // 
            this.btnSalvarFunc.Location = new System.Drawing.Point(509, 71);
            this.btnSalvarFunc.Name = "btnSalvarFunc";
            this.btnSalvarFunc.Size = new System.Drawing.Size(137, 50);
            this.btnSalvarFunc.TabIndex = 13;
            this.btnSalvarFunc.Text = "Salvar";
            this.btnSalvarFunc.UseVisualStyleBackColor = true;
            this.btnSalvarFunc.Click += new System.EventHandler(this.btnSalvarFunc_Click);
            // 
            // btnAlterarFunc
            // 
            this.btnAlterarFunc.Location = new System.Drawing.Point(509, 127);
            this.btnAlterarFunc.Name = "btnAlterarFunc";
            this.btnAlterarFunc.Size = new System.Drawing.Size(137, 50);
            this.btnAlterarFunc.TabIndex = 14;
            this.btnAlterarFunc.Text = "Alterar";
            this.btnAlterarFunc.UseVisualStyleBackColor = true;
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.Location = new System.Drawing.Point(509, 183);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(137, 50);
            this.btnExcluirFunc.TabIndex = 15;
            this.btnExcluirFunc.Text = "Excluir";
            this.btnExcluirFunc.UseVisualStyleBackColor = true;
            // 
            // btnCancelarFunc
            // 
            this.btnCancelarFunc.Location = new System.Drawing.Point(509, 239);
            this.btnCancelarFunc.Name = "btnCancelarFunc";
            this.btnCancelarFunc.Size = new System.Drawing.Size(137, 50);
            this.btnCancelarFunc.TabIndex = 16;
            this.btnCancelarFunc.Text = "Cancelar";
            this.btnCancelarFunc.UseVisualStyleBackColor = true;
            this.btnCancelarFunc.Click += new System.EventHandler(this.btnCancelarFunc_Click);
            // 
            // formAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelarFunc);
            this.Controls.Add(this.btnExcluirFunc);
            this.Controls.Add(this.btnAlterarFunc);
            this.Controls.Add(this.btnSalvarFunc);
            this.Controls.Add(this.btnNovoFunc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridSearchFuncio);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoginFunc);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.funcionario);
            this.Name = "formAtendente";
            this.Size = new System.Drawing.Size(667, 612);
            this.Load += new System.EventHandler(this.formAtendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchFuncio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txtLoginFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridSearchFuncio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscaFunc;
        private System.Windows.Forms.Button btnNovoFunc;
        private System.Windows.Forms.Button btnSalvarFunc;
        private System.Windows.Forms.Button btnAlterarFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnCancelarFunc;
    }
}
