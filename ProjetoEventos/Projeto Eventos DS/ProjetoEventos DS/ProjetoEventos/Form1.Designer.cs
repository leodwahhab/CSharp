
namespace ProjetoEventos
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
            this.components = new System.ComponentModel.Container();
            this.cmbFrutas = new System.Windows.Forms.ComboBox();
            this.pcbFrutas = new System.Windows.Forms.PictureBox();
            this.pnlTed = new System.Windows.Forms.Panel();
            this.pcbTed = new System.Windows.Forms.PictureBox();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFrutas)).BeginInit();
            this.pnlTed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTed)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFrutas
            // 
            this.cmbFrutas.AllowDrop = true;
            this.cmbFrutas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFrutas.FormattingEnabled = true;
            this.cmbFrutas.Items.AddRange(new object[] {
            "Abacaxi"});
            this.cmbFrutas.Location = new System.Drawing.Point(58, 49);
            this.cmbFrutas.Name = "cmbFrutas";
            this.cmbFrutas.Size = new System.Drawing.Size(143, 23);
            this.cmbFrutas.TabIndex = 12;
            this.cmbFrutas.SelectedIndexChanged += new System.EventHandler(this.cmbFrutas_SelectedIndexChanged);
            // 
            // pcbFrutas
            // 
            this.pcbFrutas.Location = new System.Drawing.Point(58, 160);
            this.pcbFrutas.Name = "pcbFrutas";
            this.pcbFrutas.Size = new System.Drawing.Size(160, 155);
            this.pcbFrutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFrutas.TabIndex = 14;
            this.pcbFrutas.TabStop = false;
            this.pcbFrutas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbFrutas_MouseDown);
            // 
            // pnlTed
            // 
            this.pnlTed.AllowDrop = true;
            this.pnlTed.Controls.Add(this.pcbTed);
            this.pnlTed.Location = new System.Drawing.Point(344, 49);
            this.pnlTed.Name = "pnlTed";
            this.pnlTed.Size = new System.Drawing.Size(480, 374);
            this.pnlTed.TabIndex = 16;
            this.pnlTed.MouseLeave += new System.EventHandler(this.pnlTed_MouseLeave);
            this.pnlTed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTed_MouseMove);
            // 
            // pcbTed
            // 
            this.pcbTed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbTed.Image = global::ProjetoEventos.Properties.Resources.dormindo1;
            this.pcbTed.Location = new System.Drawing.Point(130, 83);
            this.pcbTed.Name = "pcbTed";
            this.pcbTed.Size = new System.Drawing.Size(285, 278);
            this.pcbTed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTed.TabIndex = 0;
            this.pcbTed.TabStop = false;
            this.pcbTed.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbTed_DragDrop);
            this.pcbTed.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbTed_DragEnter);
            this.pcbTed.MouseLeave += new System.EventHandler(this.pcbTed_MouseLeave);
            this.pcbTed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbTed_MouseMove);
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTutorial.ForeColor = System.Drawing.Color.Maroon;
            this.lblTutorial.Location = new System.Drawing.Point(294, 34);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(389, 37);
            this.lblTutorial.TabIndex = 17;
            this.lblTutorial.Text = "Pegue o abacaxi no combobox!";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.pnlTed);
            this.Controls.Add(this.pcbFrutas);
            this.Controls.Add(this.cmbFrutas);
            this.Name = "Form1";
            this.Text = "Pegue o abacaxi no combobox!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFrutas)).EndInit();
            this.pnlTed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFrutas;
        private System.Windows.Forms.PictureBox pcbFrutas;
        private System.Windows.Forms.Panel pnlTed;
        private System.Windows.Forms.PictureBox pcbTed;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.Timer timer1;
    }
}

