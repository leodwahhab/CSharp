
namespace ProjetoCalculadoraFlex
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
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctBomba1 = new System.Windows.Forms.PictureBox();
            this.txtEtanol = new System.Windows.Forms.TextBox();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblValorEtanol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblReais = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // pctBomba1
            // 
            this.pctBomba1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.pctBomba1.Image = global::ProjetoCalculadoraFlex.Properties.Resources._26fd_removebg_preview;
            this.pctBomba1.Location = new System.Drawing.Point(298, 162);
            this.pctBomba1.Name = "pctBomba1";
            this.pctBomba1.Size = new System.Drawing.Size(183, 246);
            this.pctBomba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBomba1.TabIndex = 1;
            this.pctBomba1.TabStop = false;
            this.pctBomba1.Click += new System.EventHandler(this.pctBomba_Click);
            // 
            // txtEtanol
            // 
            this.txtEtanol.Location = new System.Drawing.Point(88, 170);
            this.txtEtanol.Name = "txtEtanol";
            this.txtEtanol.Size = new System.Drawing.Size(128, 23);
            this.txtEtanol.TabIndex = 2;
            this.txtEtanol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEtanol_KeyPress);
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(88, 256);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(128, 23);
            this.txtGasolina.TabIndex = 3;
            this.txtGasolina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGasolina_KeyPress);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trajan Pro", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(102, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(379, 41);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "CALCULADORA FLEX";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Trajan Pro", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSubTitulo.Location = new System.Drawing.Point(153, 84);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(263, 27);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Etanol ou Gasolina?";
            // 
            // lblValorEtanol
            // 
            this.lblValorEtanol.AutoSize = true;
            this.lblValorEtanol.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorEtanol.Location = new System.Drawing.Point(93, 144);
            this.lblValorEtanol.Name = "lblValorEtanol";
            this.lblValorEtanol.Size = new System.Drawing.Size(115, 23);
            this.lblValorEtanol.TabIndex = 6;
            this.lblValorEtanol.Text = "Valor do Etanol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor da Gasolina: ";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(49, 340);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(84, 28);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(164, 340);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 28);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.BackColor = System.Drawing.Color.Transparent;
            this.lblReais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReais.Location = new System.Drawing.Point(58, 172);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(24, 16);
            this.lblReais.TabIndex = 10;
            this.lblReais.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(493, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReais);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValorEtanol);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtGasolina);
            this.Controls.Add(this.txtEtanol);
            this.Controls.Add(this.pctBomba1);
            this.Controls.Add(this.pctLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBomba1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctBomba1;
        private System.Windows.Forms.TextBox txtEtanol;
        private System.Windows.Forms.TextBox txtGasolina;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblValorEtanol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblReais;
        private System.Windows.Forms.Label label1;
    }
}

