
namespace ProjetoDolarReal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbConversoes = new System.Windows.Forms.ComboBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValorConvertido = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(227, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(321, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor de moedas";
            // 
            // cmbConversoes
            // 
            this.cmbConversoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbConversoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConversoes.FormattingEnabled = true;
            this.cmbConversoes.Items.AddRange(new object[] {
            "Dólar para Real",
            "Real para Dólar"});
            this.cmbConversoes.Location = new System.Drawing.Point(297, 81);
            this.cmbConversoes.Name = "cmbConversoes";
            this.cmbConversoes.Size = new System.Drawing.Size(169, 32);
            this.cmbConversoes.TabIndex = 1;
            this.cmbConversoes.Text = "Escolha...";
            this.cmbConversoes.SelectedIndexChanged += new System.EventHandler(this.cmbConversoes_SelectedIndexChanged);
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(190, 198);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 29);
            this.txtValor1.TabIndex = 2;
            // 
            // txtValorConvertido
            // 
            this.txtValorConvertido.Enabled = false;
            this.txtValorConvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConvertido.Location = new System.Drawing.Point(514, 198);
            this.txtValorConvertido.Name = "txtValorConvertido";
            this.txtValorConvertido.Size = new System.Drawing.Size(100, 29);
            this.txtValorConvertido.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(322, 217);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 44);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Converter";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(152, 338);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 24);
            this.lblMensagem.TabIndex = 7;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(124, 161);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(0, 25);
            this.lblValor1.TabIndex = 3;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(449, 161);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(0, 25);
            this.lblValor2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValorConvertido);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.cmbConversoes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbConversoes;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValorConvertido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
    }
}

