using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEventos
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            cmbFrutas.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pcbTed.AllowDrop = true;
        }

        private void cmbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFrutas.Text.Equals("Abacaxi"))
            {
                pcbFrutas.Image = Properties.Resources.abacaxi;
                lblTutorial.Text = "Leve o abacaxi até o Ted!";
            }
        }
        private void pcbTed_MouseMove(object sender, MouseEventArgs e)
        {
            if (pcbFrutas.Image != null)
             {
                 pcbTed.Image = Properties.Resources.inshokkkk;
             }
             else
             {
                 pcbTed.Image = Properties.Resources.quase1;
                
             }
         }
         
            private void pcbTed_MouseLeave(object sender, EventArgs e)
        {
            if (pcbFrutas.Image != null)
            {
                pcbTed.Image = Properties.Resources.inshokkkk;
            }
            else
            {
                pcbTed.Image = Properties.Resources.dormindo1;
            }
        }

        private void pnlTed_MouseMove(object sender, MouseEventArgs e)
        {
            if (pcbFrutas.Image != null)
            {
                pcbTed.Image = Properties.Resources.inshokkkk;
            }
            else {
                pcbTed.Image = Properties.Resources.quase1;
            }
        }

        private void pnlTed_MouseLeave(object sender, EventArgs e)
        {
            if (pcbFrutas.Image != null)
            {
                pcbTed.Image = Properties.Resources.inshokkkk;
            }
            else
            {
                pcbTed.Image = Properties.Resources.dormindo1;
            }
        }

        private void pcbFrutas_MouseDown(object sender, MouseEventArgs e)
        {
            pcbFrutas.DoDragDrop(pcbFrutas.Image, DragDropEffects.Copy);
            
        }

        private void pcbTed_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            pcbTed.Image = Properties.Resources.acordooo1;

            
        }

        private void pcbTed_DragDrop(object sender, DragEventArgs e)
        {
            pcbTed.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            if ((Bitmap)e.Data.GetData(DataFormats.Bitmap) == Properties.Resources.abacaxi)
             {
               MessageBox.Show("erro"); 

             }
             else
             {
               pcbTed.Image = Properties.Resources.coabacaxi;
                pcbFrutas.Image = null;
                lblTutorial.Text = "O Ted agradece!";
            }
            pnlTed.Enabled = false;
            pcbTed.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
        

    }

