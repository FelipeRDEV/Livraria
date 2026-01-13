namespace Livraria
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnEditora = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnFone = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNomeUser = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.formAtendente1 = new Livraria.formAtendente();
            this.principal1 = new Livraria.Principal();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.labelNomeUser);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnCaixa);
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Controls.Add(this.btnAutores);
            this.pnlMenu.Controls.Add(this.btnEditora);
            this.pnlMenu.Controls.Add(this.btnCategoria);
            this.pnlMenu.Controls.Add(this.btnLivros);
            this.pnlMenu.Controls.Add(this.btnFone);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.btnFuncionario);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(270, 612);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCaixa.Location = new System.Drawing.Point(0, 462);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(270, 44);
            this.btnCaixa.TabIndex = 10;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPedidos.Location = new System.Drawing.Point(0, 418);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(270, 44);
            this.btnPedidos.TabIndex = 9;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAutores.Location = new System.Drawing.Point(0, 374);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(270, 44);
            this.btnAutores.TabIndex = 8;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            // 
            // btnEditora
            // 
            this.btnEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditora.Location = new System.Drawing.Point(0, 330);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.Size = new System.Drawing.Size(270, 44);
            this.btnEditora.TabIndex = 7;
            this.btnEditora.Text = "Editoras";
            this.btnEditora.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCategoria.Location = new System.Drawing.Point(0, 286);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(270, 44);
            this.btnCategoria.TabIndex = 6;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnLivros
            // 
            this.btnLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLivros.Location = new System.Drawing.Point(0, 242);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(270, 44);
            this.btnLivros.TabIndex = 5;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = true;
            // 
            // btnFone
            // 
            this.btnFone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFone.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFone.Location = new System.Drawing.Point(0, 198);
            this.btnFone.Name = "btnFone";
            this.btnFone.Size = new System.Drawing.Size(270, 44);
            this.btnFone.TabIndex = 4;
            this.btnFone.Text = "Telefones";
            this.btnFone.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCliente.Location = new System.Drawing.Point(0, 154);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(270, 44);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFuncionario.Location = new System.Drawing.Point(0, 110);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(270, 44);
            this.btnFuncionario.TabIndex = 2;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 110);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Olá,";
            // 
            // labelNomeUser
            // 
            this.labelNomeUser.AutoSize = true;
            this.labelNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNomeUser.Location = new System.Drawing.Point(64, 521);
            this.labelNomeUser.Name = "labelNomeUser";
            this.labelNomeUser.Size = new System.Drawing.Size(0, 25);
            this.labelNomeUser.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSair.Location = new System.Drawing.Point(0, 589);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(270, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // formAtendente1
            // 
            this.formAtendente1.Location = new System.Drawing.Point(266, 0);
            this.formAtendente1.Name = "formAtendente1";
            this.formAtendente1.Size = new System.Drawing.Size(667, 612);
            this.formAtendente1.TabIndex = 2;
            this.formAtendente1.Visible = false;
            // 
            // principal1
            // 
            this.principal1.Location = new System.Drawing.Point(266, 0);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(667, 612);
            this.principal1.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 612);
            this.Controls.Add(this.formAtendente1);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnEditora;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnFone;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFuncionario;
        private Principal principal1;
        private formAtendente formAtendente1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label labelNomeUser;
        private System.Windows.Forms.Label label1;
    }
}