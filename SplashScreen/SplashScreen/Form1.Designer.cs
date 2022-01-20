
namespace SplashScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdentificacaoFORM01 = new System.Windows.Forms.Label();
            this.btnAbrirForm02 = new System.Windows.Forms.Button();
            this.txtForm1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIdentificacaoFORM01
            // 
            this.lblIdentificacaoFORM01.AutoSize = true;
            this.lblIdentificacaoFORM01.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdentificacaoFORM01.Location = new System.Drawing.Point(248, 23);
            this.lblIdentificacaoFORM01.Name = "lblIdentificacaoFORM01";
            this.lblIdentificacaoFORM01.Size = new System.Drawing.Size(247, 46);
            this.lblIdentificacaoFORM01.TabIndex = 0;
            this.lblIdentificacaoFORM01.Text = "Formulário 01";
            // 
            // btnAbrirForm02
            // 
            this.btnAbrirForm02.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirForm02.Location = new System.Drawing.Point(319, 262);
            this.btnAbrirForm02.Name = "btnAbrirForm02";
            this.btnAbrirForm02.Size = new System.Drawing.Size(127, 29);
            this.btnAbrirForm02.TabIndex = 1;
            this.btnAbrirForm02.Text = "Abrir Cadastro";
            this.btnAbrirForm02.UseVisualStyleBackColor = true;
            this.btnAbrirForm02.Click += new System.EventHandler(this.btnAbrirForm02_Click);
            // 
            // txtForm1
            // 
            this.txtForm1.Location = new System.Drawing.Point(319, 175);
            this.txtForm1.Name = "txtForm1";
            this.txtForm1.Size = new System.Drawing.Size(127, 27);
            this.txtForm1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtForm1);
            this.Controls.Add(this.btnAbrirForm02);
            this.Controls.Add(this.lblIdentificacaoFORM01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificacaoFORM01;
        private System.Windows.Forms.Button btnAbrirForm02;
        private System.Windows.Forms.TextBox txtForm1;
    }
}

