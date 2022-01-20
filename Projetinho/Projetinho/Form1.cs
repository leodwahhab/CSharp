using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoOpcao1.Visible = false;
            rdoOpcao2.Visible = false;
            rdoOpcao3.Visible = false;
            rdoOpcao4.Visible = false;

            pcbImagens.Image = null;

            txtBase.Visible = false;
            txtBaseMaior.Visible = false;
            txtLado1.Visible = false;
            lblLado1.Visible = false;
            txtLado2.Visible = false;
            lblLado2.Visible = false;
            lblBase.Visible = false;
            lblBaseMaior.Visible = false;
            btnCalcular.Visible = false;
        }

        private void cmbFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBase.Visible = false;
            txtBaseMaior.Visible = false;
            txtLado1.Visible = false;
            lblLado1.Visible = false;
            txtLado2.Visible = false;
            lblLado2.Visible = false;
            lblBase.Visible = false;
            lblBaseMaior.Visible = false;
            pcbImagens.Image = null;
            rdoOpcao1.Checked = false;
            rdoOpcao2.Checked = false;
            rdoOpcao3.Checked = false;
            rdoOpcao4.Checked = false;
            btnCalcular.Visible = false;

            if (cmbFiguras.Text.Equals("Triângulo"))
            {
                rdoOpcao1.Visible = true;
                rdoOpcao1.Text = "Escaleno";
                rdoOpcao2.Visible = true;
                rdoOpcao2.Text = "Equilátero";
                rdoOpcao3.Visible = true;
                rdoOpcao3.Text = "Isósceles";
                rdoOpcao4.Visible = true;
                rdoOpcao4.Text = "Retângulo";
            }

            if (cmbFiguras.Text.Equals("Paralelogramo"))
            {
                rdoOpcao1.Visible = true;
                rdoOpcao1.Text = "Retângulo";
                rdoOpcao2.Visible = true;
                rdoOpcao2.Text = "Quadrado";
                rdoOpcao3.Visible = true;
                rdoOpcao3.Text = "Trapézio";
            }
            if (cmbFiguras.Text.Equals("Círculo"))
            {
                lblLado1.Visible = true;
                lblLado1.Text = "Raio";
                txtLado1.Visible = true;
                rdoOpcao1.Visible = false;
                rdoOpcao2.Visible = false;
                rdoOpcao3.Visible = false;
                rdoOpcao4.Visible = false;
                pcbImagens.Image = Properties.Resources.circulo;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        }

        private void rdoOpcao1_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbFiguras.Text.Equals("Triângulo"))
            {
                lblLado1.Visible = true;
                lblBase.Visible = true;
                txtLado1.Visible = true;
                txtBase.Visible = true;
                pcbImagens.Image = Properties.Resources.triangulo_escaleno;
                btnCalcular.Visible = true;
            }
            else if (cmbFiguras.Text.Equals("Paralelogramo") && rdoOpcao1.Checked)
            {
                txtLado1.Visible = true;
                lblLado1.Visible = true;
                txtBase.Visible = true;
                lblBase.Visible = true;
                pcbImagens.Image = Properties.Resources.retangulo;
                btnCalcular.Visible = true;
                lblBaseMaior.Visible = false;
                txtBaseMaior.Visible = false;
            }
        }

        private void rdoOpcao2_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbFiguras.Text.Equals("Triângulo"))
            {
                lblLado1.Visible = true;
                lblBase.Visible = true;
                txtLado1.Visible = true;
                txtBase.Visible = true;
                pcbImagens.Image = Properties.Resources.triangulo_equilatero;
                btnCalcular.Visible = true;
            }
            else if (cmbFiguras.Text.Equals("Paralelogramo") && rdoOpcao2.Checked)
            {
                txtLado1.Visible = true;
                lblLado1.Visible = true;
                pcbImagens.Image = Properties.Resources.quadrado;
                btnCalcular.Visible = true;
                lblBaseMaior.Visible = false;
                txtBaseMaior.Visible = false;
            }
        }

        private void rdoOpcao3_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbFiguras.Text.Equals("Triângulo"))
            {
                lblLado1.Visible = true;
                lblBase.Visible = true;
                txtLado1.Visible = true;
                txtBase.Visible = true;
                pcbImagens.Image = Properties.Resources.triangulo_isosceles;
                btnCalcular.Visible = true;
            }
            else if (cmbFiguras.Text.Equals("Paralelogramo") && rdoOpcao3.Checked)
            {
                txtLado1.Visible = true;
                lblLado1.Visible = true;
                txtBase.Visible = true;
                lblBase.Visible = true;
                txtBaseMaior.Visible = true;
                lblBaseMaior.Visible = true;
                pcbImagens.Image = Properties.Resources.trapezio;
                btnCalcular.Visible = true;
            }
        }

        private void rdoOpcao4_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbFiguras.Text.Equals("Triângulo"))
            {
                pcbImagens.Image = Properties.Resources.triangulo_retangulo;
                btnCalcular.Visible = true;
            }
        }
    }
}
