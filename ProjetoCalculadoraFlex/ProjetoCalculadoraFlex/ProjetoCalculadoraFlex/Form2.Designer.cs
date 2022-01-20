
namespace ProjetoCalculadoraFlex
{
    partial class Form2
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
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctBomba1 = new System.Windows.Forms.PictureBox();
            this.lblAbasteca = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBomba1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::ProjetoCalculadoraFlex.Properties.Resources.Shell_Logo;
            this.pctLogo.Location = new System.Drawing.Point(-9, 1);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(127, 83);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trajan Pro", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(100, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(379, 41);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "CALCULADORA FLEX";
            // 
            // pctBomba1
            // 
            this.pctBomba1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pctBomba1.Image = global::ProjetoCalculadoraFlex.Properties.Resources._26fd_removebg_preview;
            this.pctBomba1.Location = new System.Drawing.Point(296, 160);
            this.pctBomba1.Name = "pctBomba1";
            this.pctBomba1.Size = new System.Drawing.Size(183, 246);
            this.pctBomba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBomba1.TabIndex = 6;
            this.pctBomba1.TabStop = false;
            this.pctBomba1.Click += new System.EventHandler(this.pctBomba1_Click);
            // 
            // lblAbasteca
            // 
            this.lblAbasteca.AutoSize = true;
            this.lblAbasteca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAbasteca.Location = new System.Drawing.Point(61, 160);
            this.lblAbasteca.Name = "lblAbasteca";
            this.lblAbasteca.Size = new System.Drawing.Size(139, 25);
            this.lblAbasteca.TabIndex = 7;
            this.lblAbasteca.Text = "Abasteça com:";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustivel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustivel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCombustivel.Location = new System.Drawing.Point(80, 185);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(0, 32);
            this.lblCombustivel.TabIndex = 8;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(179, 318);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 29);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(491, 475);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.lblAbasteca);
            this.Controls.Add(this.pctBomba1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBomba1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pctBomba1;
        private System.Windows.Forms.Label lblAbasteca;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Button btnVoltar;
    }
}