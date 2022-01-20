
namespace ProjConversoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbValor1 = new System.Windows.Forms.ComboBox();
            this.cmbValor2 = new System.Windows.Forms.ComboBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(167, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(383, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversão de Moedas\r\n";
            // 
            // cmbValor1
            // 
            this.cmbValor1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValor1.FormattingEnabled = true;
            this.cmbValor1.Location = new System.Drawing.Point(129, 138);
            this.cmbValor1.Name = "cmbValor1";
            this.cmbValor1.Size = new System.Drawing.Size(145, 23);
            this.cmbValor1.TabIndex = 1;
            // 
            // cmbValor2
            // 
            this.cmbValor2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValor2.FormattingEnabled = true;
            this.cmbValor2.Location = new System.Drawing.Point(414, 134);
            this.cmbValor2.Name = "cmbValor2";
            this.cmbValor2.Size = new System.Drawing.Size(145, 23);
            this.cmbValor2.TabIndex = 2;
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(129, 194);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(145, 40);
            this.txtValor1.TabIndex = 4;
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(414, 194);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(145, 40);
            this.txtValor2.TabIndex = 5;
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(307, 197);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 32);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnTrocar
            // 
            this.btnTrocar.BackColor = System.Drawing.Color.Transparent;
            this.btnTrocar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrocar.BackgroundImage")));
            this.btnTrocar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocar.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocar.Image")));
            this.btnTrocar.Location = new System.Drawing.Point(328, 139);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(32, 22);
            this.btnTrocar.TabIndex = 3;
            this.btnTrocar.UseVisualStyleBackColor = false;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(694, 345);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.cmbValor2);
            this.Controls.Add(this.cmbValor1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Conversor de Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbValor1;
        private System.Windows.Forms.ComboBox cmbValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnTrocar;
    }
}

