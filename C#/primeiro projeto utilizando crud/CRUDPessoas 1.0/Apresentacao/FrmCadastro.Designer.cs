namespace CRUDPessoas_1._0.Apresentacao
{
    partial class FrmCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNome
            // 
            this.txbNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbNome.Location = new System.Drawing.Point(13, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(196, 20);
            this.txbNome.TabIndex = 1;
            this.txbNome.Text = "Digite aqui...";
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(4, 72);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG";
            this.lblRG.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbRG
            // 
            this.txbRG.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbRG.Location = new System.Drawing.Point(13, 88);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(196, 20);
            this.txbRG.TabIndex = 3;
            this.txbRG.Text = "Digite aqui...";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(13, 209);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(196, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(2, 129);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF";
            // 
            // txbCPF
            // 
            this.txbCPF.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCPF.Location = new System.Drawing.Point(12, 145);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(197, 20);
            this.txbCPF.TabIndex = 6;
            this.txbCPF.Text = "Digite aqui...";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 259);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro de Pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbCPF;
    }
}