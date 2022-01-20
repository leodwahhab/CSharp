
namespace ProjetoConversao
{
    partial class Form1
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.cmbValor2 = new System.Windows.Forms.ComboBox();
            this.cmbValor1 = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConverter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConverter.Location = new System.Drawing.Point(316, 137);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 32);
            this.btnConverter.TabIndex = 12;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click_1);
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValor2.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(423, 193);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(145, 38);
            this.txtValor2.TabIndex = 11;
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtReal
            // 
            this.txtReal.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReal.Location = new System.Drawing.Point(138, 193);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(145, 38);
            this.txtReal.TabIndex = 10;
            this.txtReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbValor2
            // 
            this.cmbValor2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValor2.FormattingEnabled = true;
            this.cmbValor2.Location = new System.Drawing.Point(423, 137);
            this.cmbValor2.Name = "cmbValor2";
            this.cmbValor2.Size = new System.Drawing.Size(145, 23);
            this.cmbValor2.TabIndex = 9;
            // 
            // cmbValor1
            // 
            this.cmbValor1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValor1.FormattingEnabled = true;
            this.cmbValor1.Location = new System.Drawing.Point(138, 137);
            this.cmbValor1.Name = "cmbValor1";
            this.cmbValor1.Size = new System.Drawing.Size(145, 23);
            this.cmbValor1.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(168, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(383, 39);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Conversão de Moedas\r\n";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(134, 113);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(112, 21);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Converter de:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(419, 113);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 21);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "Para:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(700, 335);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.cmbValor2);
            this.Controls.Add(this.cmbValor1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.ComboBox cmbValor2;
        private System.Windows.Forms.ComboBox cmbValor1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

