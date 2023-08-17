using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_noite
{
    public partial class Form1 : Form
    {
        //Declaração da matriz e variaveis
        string[,] matriz = new string[6, 6];
        string correta = "", resposta = "";
        int linha = 0, pontos = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        //Inserindo as perguntas na matriz
        private void Form1_Load(object sender, EventArgs e)
        {
            matriz[0, 0] = "Qual o nome do local em que Finn e Jake moram?";
            matriz[0, 1] = "Terra de Ooo";
            matriz[0, 2] = "Reino Doce";
            matriz[0, 3] = "Cidadela de Cristal";
            matriz[0, 4] = "Trem Masmorra";
            matriz[0, 5] = "Terra de Ooo";

            matriz[1, 0] = "Qual é o nome da princesa que Finn tem uma queda?";
            matriz[1, 1] = "Princesa Caroço";
            matriz[1, 2] = "Princesa Algodão Doce";
            matriz[1, 3] = "Princesa Jujuba";
            matriz[1, 4] = "Princesa de Fogo";
            matriz[1, 5] = "Princesa Jujuba";

            matriz[2, 0] = "Qual o nome do videogame-robô que Finn e Jake tem?";
            matriz[2, 1] = "PS2";
            matriz[2, 2] = "XBOX";
            matriz[2, 3] = "BMO";
            matriz[2, 4] = "SNES";
            matriz[2, 5] = "BMO";

            matriz[3, 0] = "Qual dessas é a namorada do Jake?";
            matriz[3, 1] = "Lady Íris";
            matriz[3, 2] = "Canelinha";
            matriz[3, 3] = "Marceline";
            matriz[3, 4] = "Dona Tromba";
            matriz[3, 5] = "Lady Íris";

            matriz[4, 0] = "Qual é o personagem mais forte da série?";
            matriz[4, 1] = "Rei Gelado";
            matriz[4, 2] = "Lich";
            matriz[4, 3] = "Rei de fogo";
            matriz[4, 4] = "Gunter";
            matriz[4, 5] = "Lich";

            matriz[5, 0] = "Marceline é conhecida por ser...";
            matriz[5, 1] = "Por ser popular";
            matriz[5, 2] = "Por poder voar";
            matriz[5, 3] = "Por ser fofa";
            matriz[5, 4] = "Por ser uma vampira";
            matriz[5, 5] = "Por ser uma vampira";


        }

        
        //inicio botao clicar
        private void Btiniciar_Click(object sender, EventArgs e)
        {
            grupo.Visible = true;
            btiniciar.Visible = false;
            linha = 0;
            Preencher();
            pontos = 0;
            
            lblPontos.Text = pontos.ToString();
            Desmarcar();
        }//fim botao clicar

        
        private void Desmarcar() //função desmarcar
        {
            resp1.Checked = false;
            resp2.Checked = false;
            resp3.Checked = false;
            resp4.Checked = false;
        }
        private void Preencher() //função preencher
        {
            lblPergunta.Text = matriz[linha, 0];
            resp1.Text = matriz[linha, 1];
            resp2.Text = matriz[linha, 2];
            resp3.Text = matriz[linha, 3];
            resp4.Text = matriz[linha, 4];
            correta = matriz[linha, 5];
        }

        //inicio da definição dos textos das RadioBottons
        private void Resp1_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp1.Text;
        }

        private void Resp2_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp2.Text;
        }


        private void Resp3_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp3.Text;
        }

        private void LblPergunta_Click(object sender, EventArgs e)
        {

        }

        private void Resp4_CheckedChanged(object sender, EventArgs e)
        {
            resposta = resp4.Text;
        }
        //fim da definição dos textos das RadioBottons


        //inicio botão próximo
        private void BtProximo_Click(object sender, EventArgs e)
        {
            if (resp1.Checked == false && resp2.Checked == false && resp3.Checked == false && resp4.Checked == false)
            {
                MessageBox.Show("Ei aventureiro, escolha uma opção!");
            }
            else
            {
                //verificar acerto
                if(resposta == correta)
                {
                    pontos++;
                    lblPontos.Text = pontos.ToString();
                }
                if (linha < 5)
                {
                    linha++;
                    Desmarcar(); Preencher();
                }
                else
                {
                    MessageBox.Show("Parabéns Aventureiro! Você terminou o Quiz ;)");
                    grupo.Visible = false;
                    btiniciar.Visible = true;
                }

            }

        } //fim btProximo


    }


}
