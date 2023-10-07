namespace DesktopPim
{
    partial class FrmMenu
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnAdcFunc = new System.Windows.Forms.Button();
            this.btnCadCargo = new System.Windows.Forms.Button();
            this.btnListFunc = new System.Windows.Forms.Button();
            this.btnCargContas = new System.Windows.Forms.Button();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.btnDadosFunc = new System.Windows.Forms.Button();
            this.btnApagarFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(174, 45);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(123, 39);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "MENU";
            this.lblMenuPrincipal.UseWaitCursor = true;
            // 
            // btnAdcFunc
            // 
            this.btnAdcFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdcFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcFunc.Location = new System.Drawing.Point(66, 130);
            this.btnAdcFunc.Name = "btnAdcFunc";
            this.btnAdcFunc.Size = new System.Drawing.Size(90, 52);
            this.btnAdcFunc.TabIndex = 1;
            this.btnAdcFunc.Text = "Adicionar funcionario";
            this.btnAdcFunc.UseVisualStyleBackColor = false;
            this.btnAdcFunc.UseWaitCursor = true;
            this.btnAdcFunc.Click += new System.EventHandler(this.btnAdcFunc_Click);
            // 
            // btnCadCargo
            // 
            this.btnCadCargo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCargo.Location = new System.Drawing.Point(66, 209);
            this.btnCadCargo.Name = "btnCadCargo";
            this.btnCadCargo.Size = new System.Drawing.Size(90, 58);
            this.btnCadCargo.TabIndex = 3;
            this.btnCadCargo.Text = "Cadastro de cargos";
            this.btnCadCargo.UseVisualStyleBackColor = false;
            this.btnCadCargo.UseWaitCursor = true;
            this.btnCadCargo.Click += new System.EventHandler(this.btnCadCargo_Click);
            // 
            // btnListFunc
            // 
            this.btnListFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListFunc.Location = new System.Drawing.Point(66, 282);
            this.btnListFunc.Name = "btnListFunc";
            this.btnListFunc.Size = new System.Drawing.Size(90, 47);
            this.btnListFunc.TabIndex = 4;
            this.btnListFunc.Text = "Lista de funcionarios";
            this.btnListFunc.UseVisualStyleBackColor = false;
            this.btnListFunc.UseWaitCursor = true;
            this.btnListFunc.Click += new System.EventHandler(this.btnListFunc_Click);
            // 
            // btnCargContas
            // 
            this.btnCargContas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargContas.Location = new System.Drawing.Point(326, 209);
            this.btnCargContas.Name = "btnCargContas";
            this.btnCargContas.Size = new System.Drawing.Size(95, 58);
            this.btnCargContas.TabIndex = 7;
            this.btnCargContas.Text = "Cargos e Contas";
            this.btnCargContas.UseVisualStyleBackColor = false;
            this.btnCargContas.UseWaitCursor = true;
            this.btnCargContas.Click += new System.EventHandler(this.btnCargContas_Click);
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFunc.Location = new System.Drawing.Point(326, 132);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(95, 48);
            this.btnEditarFunc.TabIndex = 8;
            this.btnEditarFunc.Text = "Editar Funcionarios";
            this.btnEditarFunc.UseVisualStyleBackColor = false;
            this.btnEditarFunc.UseWaitCursor = true;
            this.btnEditarFunc.Click += new System.EventHandler(this.btnEditarFunc_Click);
            // 
            // btnDadosFunc
            // 
            this.btnDadosFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDadosFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosFunc.Location = new System.Drawing.Point(326, 282);
            this.btnDadosFunc.Name = "btnDadosFunc";
            this.btnDadosFunc.Size = new System.Drawing.Size(95, 47);
            this.btnDadosFunc.TabIndex = 10;
            this.btnDadosFunc.Text = "Dados Funcionarios";
            this.btnDadosFunc.UseVisualStyleBackColor = false;
            this.btnDadosFunc.UseWaitCursor = true;
            this.btnDadosFunc.Click += new System.EventHandler(this.btnDadosFunc_Click);
            // 
            // btnApagarFunc
            // 
            this.btnApagarFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApagarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarFunc.Location = new System.Drawing.Point(66, 358);
            this.btnApagarFunc.Name = "btnApagarFunc";
            this.btnApagarFunc.Size = new System.Drawing.Size(95, 54);
            this.btnApagarFunc.TabIndex = 12;
            this.btnApagarFunc.Text = "Apagar Funcionário";
            this.btnApagarFunc.UseVisualStyleBackColor = false;
            this.btnApagarFunc.UseWaitCursor = true;
            this.btnApagarFunc.Click += new System.EventHandler(this.btnApagarFunc_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 475);
            this.Controls.Add(this.btnApagarFunc);
            this.Controls.Add(this.btnDadosFunc);
            this.Controls.Add(this.btnEditarFunc);
            this.Controls.Add(this.btnCargContas);
            this.Controls.Add(this.btnListFunc);
            this.Controls.Add(this.btnCadCargo);
            this.Controls.Add(this.btnAdcFunc);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnAdcFunc;
        private System.Windows.Forms.Button btnCadCargo;
        private System.Windows.Forms.Button btnListFunc;
        private System.Windows.Forms.Button btnCargContas;
        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.Button btnDadosFunc;
        private System.Windows.Forms.Button btnApagarFunc;
    }
}

