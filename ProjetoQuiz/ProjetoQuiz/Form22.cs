using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            
            Boolean eren, reiner, zeke, resposta1, resposta2, resposta3, resposta4;
            String e1, e2, e3, e4;
            eren = cmbP3.Text.Equals("Eren");
            reiner = cmbP3.Text.Equals("Reiner");
            zeke = cmbP3.Text.Equals("Zeke");

            resposta1 = rdoP1Certa.Checked;
            resposta2 = rdoP2Certa.Checked;
            resposta3 = eren && rdoP3Alt2.Checked || reiner && rdoP3Alt3.Checked || zeke && rdoP3Alt5.Checked; ;
            resposta4 = rdoP4Certa.Checked;


            if (!chkP1.Checked || !chkP2.Checked || !chkP3.Checked || !chkP4.Checked)
            {
                lblMensagem.Text = "Só é possível corrigir quando todas as perguntas estão respondidas";
            }
            else
            {
                int resp1, resp2, resp3, resp4;
                int[] erradas;
                erradas = new int [3];

                if (resposta1)
                {
                    resp1 = 1;
                }
                else
                {
                    resp1 = 0;
                    erradas[0] = 1;
                    // lblMensagemErradas.Text = "A questão 1 está errada";
                    e1 = "1";
                }

                if (resposta2)
                {
                    resp2 = 1;
                }
                else
                {
                    resp2 = 0;
                    e2 = "2";
                }

                if (resposta3)
                {
                    resp3 = 1;
                }
                else
                {
                    resp3 = 0;
                    e3 = "3";
                }

                if (resposta4)
                {
                    resp4 = 1;
                }
                else
                {
                    resp4 = 0;
                    //erradas[3] = 4;
                    e4 = "4";
                }

                /*String msgerrada = "As questões ";
                String msgefinal = " estão erradas";
                String ind;
                lblMensagemErradas.Text = msgerrada;
                for (int c = 0; c < 4; c++)
                {
                    ind = Convert.ToString(c);
                    lblMensagemErradas.Text = msgerrada + erradas[Convert.ToInt32(ind)];
                }*/6


                int mencao;
                mencao = resp1 + resp2 + resp3 + resp4;
                
                if(mencao < 2)
                {
                    lblMensagem.Text = "0 ou 1 correta, menção I";
                }
                else
                {
                    if (mencao == 2)
                    {
                        lblMensagem.Text = "2 corretas, menção R";
                    }
                    else
                    {
                        if (mencao == 3)
                        {
                            lblMensagem.Text = "3 corretas, menção B";
                        }
                        else
                        {
                            if (mencao == 4)
                            {
                                lblMensagem.Text = "4 corretas, menção MB";
                            }
                        }
                    }
                }
            }   
        }

        private void cmbP3_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkP3.Checked = false;
            rdoP3Alt1.Checked = false;
            rdoP3Alt2.Checked = false;
            rdoP3Alt3.Checked = false;
            rdoP3Alt4.Checked = false;
            rdoP3Alt5.Checked = false;           
        }

        private void chkP3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
