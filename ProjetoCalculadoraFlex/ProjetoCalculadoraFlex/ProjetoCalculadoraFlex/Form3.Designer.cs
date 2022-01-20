
namespace ProjetoCalculadoraFlex
{
    partial class Form3
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
            this.lblNomes = new System.Windows.Forms.Label();
            this.lblLeonardo = new System.Windows.Forms.Label();
            this.lblMateus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBomba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::ProjetoCalculadoraFlex.Properties.Resources.Shell_Logo;
            this.pctLogo.Location = new System.Drawing.Point(-7, -1);
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
            this.lblTitulo.Location = new System.Drawing.Point(101, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(379, 41);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "CALCULADORA FLEX";
            // 
            // pctBomba1
            // 
            this.pctBomba1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pctBomba1.Image = global::ProjetoCalculadoraFlex.Properties.Resources._26fd_removebg_preview;
            this.pctBomba1.Location = new System.Drawing.Point(297, 128);
            this.pctBomba1.Name = "pctBomba1";
            this.pctBomba1.Size = new System.Drawing.Size(183, 246);
            this.pctBomba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBomba1.TabIndex = 7;
            this.pctBomba1.TabStop = false;
            // 
            // lblNomes
            // 
            this.lblNomes.AutoSize = true;
            this.lblNomes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomes.Location = new System.Drawing.Point(297, 377);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(94, 20);
            this.lblNomes.TabIndex = 10;
            this.lblNomes.Text = "Integrantes:";
            // 
            // lblLeonardo
            // 
            this.lblLeonardo.AutoSize = true;
            this.lblLeonardo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeonardo.Location = new System.Drawing.Point(297, 406);
            this.lblLeonardo.Name = "lblLeonardo";
            this.lblLeonardo.Size = new System.Drawing.Size(188, 20);
            this.lblLeonardo.TabIndex = 11;
            this.lblLeonardo.Text = "Leonardo Dumont Wahhab";
            // 
            // lblMateus
            // 
            this.lblMateus.AutoSize = true;
            this.lblMateus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateus.Location = new System.Drawing.Point(297, 435);
            this.lblMateus.Name = "lblMateus";
            this.lblMateus.Size = new System.Drawing.Size(169, 20);
            this.lblMateus.TabIndex = 12;
            this.lblMateus.Text = "Mateus Ferreira Linhares";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoCalculadoraFlex.Properties.Resources.txtttt;
            this.pictureBox1.Location = new System.Drawing.Point(-45, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(251, 314);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 30);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(492, 475);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMateus);
            this.Controls.Add(this.lblLeonardo);
            this.Controls.Add(this.lblNomes);
            this.Controls.Add(this.pctBomba1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBomba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pctBomba1;
        private System.Windows.Forms.Label lblNomes;
        private System.Windows.Forms.Label lblLeonardo;
        private System.Windows.Forms.Label lblMateus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}