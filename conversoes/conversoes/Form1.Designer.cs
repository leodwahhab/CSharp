
namespace conversoes
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.rdoRealDolar = new System.Windows.Forms.RadioButton();
            this.rdoDolarReal = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(220, 249);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label1";
            // 
            // rdoRealDolar
            // 
            this.rdoRealDolar.AutoSize = true;
            this.rdoRealDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRealDolar.Location = new System.Drawing.Point(224, 165);
            this.rdoRealDolar.Name = "rdoRealDolar";
            this.rdoRealDolar.Size = new System.Drawing.Size(135, 24);
            this.rdoRealDolar.TabIndex = 1;
            this.rdoRealDolar.TabStop = true;
            this.rdoRealDolar.Text = "Real para dólar";
            this.rdoRealDolar.UseVisualStyleBackColor = true;
            this.rdoRealDolar.CheckedChanged += new System.EventHandler(this.rdoOpcao1_CheckedChanged);
            // 
            // rdoDolarReal
            // 
            this.rdoDolarReal.AutoSize = true;
            this.rdoDolarReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDolarReal.Location = new System.Drawing.Point(410, 165);
            this.rdoDolarReal.Name = "rdoDolarReal";
            this.rdoDolarReal.Size = new System.Drawing.Size(122, 24);
            this.rdoDolarReal.TabIndex = 2;
            this.rdoDolarReal.TabStop = true;
            this.rdoDolarReal.Text = "Dólar pra real";
            this.rdoDolarReal.UseVisualStyleBackColor = true;
            this.rdoDolarReal.CheckedChanged += new System.EventHandler(this.rdoOpcao2_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(279, 113);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(192, 31);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Converter de:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(420, 249);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(51, 20);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Conversor de Moedas";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(224, 272);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(108, 31);
            this.txtValor.TabIndex = 6;
           
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.Location = new System.Drawing.Point(424, 272);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(108, 31);
            this.txtRes.TabIndex = 7;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(341, 340);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(88, 33);
            this.btnConverter.TabIndex = 8;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rdoDolarReal);
            this.Controls.Add(this.rdoRealDolar);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton rdoRealDolar;
        private System.Windows.Forms.RadioButton rdoDolarReal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnConverter;
    }
}

