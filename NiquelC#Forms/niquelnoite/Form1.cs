using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niquelnoite
{
    public partial class Form1 : Form
    {
        int qtde = 0, pontos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btjogar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void Lblpontos_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random sorteio = new Random(); //Random gera números aleatórios
            int num1, num2, num3;
            num1 = sorteio.Next(1, 7); num2 = sorteio.Next(1, 7); num3 = sorteio.Next(1, 7);


            //encontra as imagens sorteadas que estão salvas no executavel
            pic1.Load(Application.StartupPath + "\\frutas\\" + num1 + ".png");
            pic2.Load(Application.StartupPath + "\\frutas\\" + num2 + ".png");
            pic3.Load(Application.StartupPath + "\\frutas\\" + num3 + ".png");

            qtde = qtde + 1;
                if (qtde > 10)
                {
                    timer1.Enabled = false;
                    qtde = 0;            
                
                    //verifica se acertou as 3 imagens
                    if (num1 == num2 && num2 == num3 && num1 == num3)
                    {
                        num1 = 5; //dificulta o jogo
                        pontos = pontos + 10; //ganha pontos
                        lblpontos.Text = pontos.ToString();
                    }
                        else if(num1 == num2 || num2 == num3 || num1 == num3)
                        {
                            pontos = pontos + 1;
                            lblpontos.Text = pontos.ToString();
                        }
                            else if (num1 != num2 && num2 != num3 && num1 != num3)
                            {
                                pontos = pontos - 3;
                                lblpontos.Text = pontos.ToString();
                                if (pontos <=0 )
                                {
                                    pontos = 0;
                                    lblpontos.Text = pontos.ToString();
                                }
                            }

            }
        }
    }
}
