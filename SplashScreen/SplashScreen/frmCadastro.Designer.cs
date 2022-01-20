
namespace SplashScreen
{
    partial class frmCadastro
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
            this.btnAbrirForm01 = new System.Windows.Forms.Button();
            this.lblIdentificacaoCadastro = new System.Windows.Forms.Label();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirForm01
            // 
            this.btnAbrirForm01.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirForm01.Location = new System.Drawing.Point(329, 219);
            this.btnAbrirForm01.Name = "btnAbrirForm01";
            this.btnAbrirForm01.Size = new System.Drawing.Size(127, 29);
            this.btnAbrirForm01.TabIndex = 3;
            this.btnAbrirForm01.Text = "Abrir FORM 01";
            this.btnAbrirForm01.UseVisualStyleBackColor = true;
            this.btnAbrirForm01.Click += new System.EventHandler(this.btnAbrirForm01_Click);
            // 
            // lblIdentificacaoCadastro
            // 
            this.lblIdentificacaoCadastro.AutoSize = true;
            this.lblIdentificacaoCadastro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdentificacaoCadastro.Location = new System.Drawing.Point(305, 9);
            this.lblIdentificacaoCadastro.Name = "lblIdentificacaoCadastro";
            this.lblIdentificacaoCadastro.Size = new System.Drawing.Size(161, 46);
            this.lblIdentificacaoCadastro.TabIndex = 2;
            this.lblIdentificacaoCadastro.Text = "Cadastro";
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Location = new System.Drawing.Point(329, 146);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(50, 20);
            this.lblConteudo.TabIndex = 4;
            this.lblConteudo.Text = "label1";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.btnAbrirForm01);
            this.Controls.Add(this.lblIdentificacaoCadastro);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirForm01;
        private System.Windows.Forms.Label lblIdentificacaoCadastro;
        private System.Windows.Forms.Label lblConteudo;
    }
}