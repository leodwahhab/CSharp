
namespace Projetinho
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.gpbFiguras = new System.Windows.Forms.GroupBox();
            this.rdoOpcao4 = new System.Windows.Forms.RadioButton();
            this.rdoOpcao3 = new System.Windows.Forms.RadioButton();
            this.rdoOpcao2 = new System.Windows.Forms.RadioButton();
            this.rdoOpcao1 = new System.Windows.Forms.RadioButton();
            this.cmbFiguras = new System.Windows.Forms.ComboBox();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblBaseMaior = new System.Windows.Forms.Label();
            this.txtBaseMaior = new System.Windows.Forms.TextBox();
            this.gpbFiguras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(507, 321);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(110, 20);
            this.txtBase.TabIndex = 0;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(698, 179);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 1;
            // 
            // gpbFiguras
            // 
            this.gpbFiguras.Controls.Add(this.rdoOpcao4);
            this.gpbFiguras.Controls.Add(this.rdoOpcao3);
            this.gpbFiguras.Controls.Add(this.rdoOpcao2);
            this.gpbFiguras.Controls.Add(this.rdoOpcao1);
            this.gpbFiguras.Controls.Add(this.cmbFiguras);
            this.gpbFiguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFiguras.Location = new System.Drawing.Point(26, 38);
            this.gpbFiguras.Name = "gpbFiguras";
            this.gpbFiguras.Size = new System.Drawing.Size(228, 315);
            this.gpbFiguras.TabIndex = 3;
            this.gpbFiguras.TabStop = false;
            this.gpbFiguras.Text = "Figuras Geométricas";
            // 
            // rdoOpcao4
            // 
            this.rdoOpcao4.AutoSize = true;
            this.rdoOpcao4.Location = new System.Drawing.Point(23, 240);
            this.rdoOpcao4.Name = "rdoOpcao4";
            this.rdoOpcao4.Size = new System.Drawing.Size(14, 13);
            this.rdoOpcao4.TabIndex = 4;
            this.rdoOpcao4.TabStop = true;
            this.rdoOpcao4.UseVisualStyleBackColor = true;
            this.rdoOpcao4.Visible = false;
            this.rdoOpcao4.CheckedChanged += new System.EventHandler(this.rdoOpcao4_CheckedChanged);
            // 
            // rdoOpcao3
            // 
            this.rdoOpcao3.AutoSize = true;
            this.rdoOpcao3.Location = new System.Drawing.Point(23, 193);
            this.rdoOpcao3.Name = "rdoOpcao3";
            this.rdoOpcao3.Size = new System.Drawing.Size(14, 13);
            this.rdoOpcao3.TabIndex = 3;
            this.rdoOpcao3.TabStop = true;
            this.rdoOpcao3.UseVisualStyleBackColor = true;
            this.rdoOpcao3.Visible = false;
            this.rdoOpcao3.CheckedChanged += new System.EventHandler(this.rdoOpcao3_CheckedChanged);
            // 
            // rdoOpcao2
            // 
            this.rdoOpcao2.AutoSize = true;
            this.rdoOpcao2.Location = new System.Drawing.Point(23, 146);
            this.rdoOpcao2.Name = "rdoOpcao2";
            this.rdoOpcao2.Size = new System.Drawing.Size(14, 13);
            this.rdoOpcao2.TabIndex = 2;
            this.rdoOpcao2.TabStop = true;
            this.rdoOpcao2.UseVisualStyleBackColor = true;
            this.rdoOpcao2.Visible = false;
            this.rdoOpcao2.CheckedChanged += new System.EventHandler(this.rdoOpcao2_CheckedChanged);
            // 
            // rdoOpcao1
            // 
            this.rdoOpcao1.AutoSize = true;
            this.rdoOpcao1.Location = new System.Drawing.Point(23, 99);
            this.rdoOpcao1.Name = "rdoOpcao1";
            this.rdoOpcao1.Size = new System.Drawing.Size(14, 13);
            this.rdoOpcao1.TabIndex = 1;
            this.rdoOpcao1.TabStop = true;
            this.rdoOpcao1.UseVisualStyleBackColor = true;
            this.rdoOpcao1.Visible = false;
            this.rdoOpcao1.CheckedChanged += new System.EventHandler(this.rdoOpcao1_CheckedChanged);
            // 
            // cmbFiguras
            // 
            this.cmbFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiguras.FormattingEnabled = true;
            this.cmbFiguras.Items.AddRange(new object[] {
            "Triângulo",
            "Paralelogramo",
            "Círculo"});
            this.cmbFiguras.Location = new System.Drawing.Point(18, 41);
            this.cmbFiguras.Name = "cmbFiguras";
            this.cmbFiguras.Size = new System.Drawing.Size(121, 26);
            this.cmbFiguras.TabIndex = 0;
            this.cmbFiguras.SelectedIndexChanged += new System.EventHandler(this.cmbFiguras_SelectedIndexChanged);
            // 
            // pcbImagens
            // 
            this.pcbImagens.Image = global::Projetinho.Properties.Resources.triangulo_retangulo;
            this.pcbImagens.Location = new System.Drawing.Point(431, 61);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(225, 225);
            this.pcbImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagens.TabIndex = 4;
            this.pcbImagens.TabStop = false;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(348, 179);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(76, 20);
            this.txtLado1.TabIndex = 5;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(70, 388);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(17, 25);
            this.lblMensagem.TabIndex = 6;
            this.lblMensagem.Text = "l";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(291, 266);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 38);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.Location = new System.Drawing.Point(345, 163);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(39, 15);
            this.lblLado1.TabIndex = 7;
            this.lblLado1.Text = "Lado";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(462, 321);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(39, 15);
            this.lblBase.TabIndex = 8;
            this.lblBase.Text = "Base";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.Location = new System.Drawing.Point(697, 163);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(39, 15);
            this.lblLado2.TabIndex = 9;
            this.lblLado2.Text = "Lado";
            // 
            // lblBaseMaior
            // 
            this.lblBaseMaior.AutoSize = true;
            this.lblBaseMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMaior.Location = new System.Drawing.Point(462, 25);
            this.lblBaseMaior.Name = "lblBaseMaior";
            this.lblBaseMaior.Size = new System.Drawing.Size(39, 15);
            this.lblBaseMaior.TabIndex = 11;
            this.lblBaseMaior.Text = "Base";
            // 
            // txtBaseMaior
            // 
            this.txtBaseMaior.Location = new System.Drawing.Point(507, 25);
            this.txtBaseMaior.Name = "txtBaseMaior";
            this.txtBaseMaior.Size = new System.Drawing.Size(110, 20);
            this.txtBaseMaior.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lblBaseMaior);
            this.Controls.Add(this.txtBaseMaior);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.pcbImagens);
            this.Controls.Add(this.gpbFiguras);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbFiguras.ResumeLayout(false);
            this.gpbFiguras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.GroupBox gpbFiguras;
        private System.Windows.Forms.RadioButton rdoOpcao4;
        private System.Windows.Forms.RadioButton rdoOpcao3;
        private System.Windows.Forms.RadioButton rdoOpcao2;
        private System.Windows.Forms.RadioButton rdoOpcao1;
        private System.Windows.Forms.ComboBox cmbFiguras;
        private System.Windows.Forms.PictureBox pcbImagens;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblBaseMaior;
        private System.Windows.Forms.TextBox txtBaseMaior;
    }
}

