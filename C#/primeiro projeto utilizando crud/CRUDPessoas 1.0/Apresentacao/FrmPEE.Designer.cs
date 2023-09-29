namespace CRUDPessoas_1._0.Apresentacao
{
    partial class FrmPEE
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
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(7, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(15, 25);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(216, 20);
            this.txbID.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(256, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txbCPF
            // 
            this.txbCPF.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCPF.Location = new System.Drawing.Point(15, 232);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(197, 20);
            this.txbCPF.TabIndex = 13;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(5, 216);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(15, 283);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(142, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txbRG
            // 
            this.txbRG.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbRG.Location = new System.Drawing.Point(16, 175);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(196, 20);
            this.txbRG.TabIndex = 10;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(7, 159);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 9;
            this.lblRG.Text = "RG";
            // 
            // txbNome
            // 
            this.txbNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbNome.Location = new System.Drawing.Point(16, 113);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(196, 20);
            this.txbNome.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(190, 283);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(141, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmPEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 342);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblID);
            this.Name = "FrmPEE";
            this.Text = "Pesquisar, Editar e Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
    }
}