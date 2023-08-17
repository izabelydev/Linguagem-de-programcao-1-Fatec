using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1803
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtMais_Click(object sender, EventArgs e)
        {
            if (pic.Width <= 60000 && pic.Height <= 60000)
            {
                pic.Width = Convert.ToInt32(pic.Width * 1.25);
                    pic.Height = Convert.ToInt32(pic.Height * 1.25);
            }
                else
                {
                    MessageBox.Show("Limite de tamanho máximo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

        }

        private void BtMenos_Click(object sender, EventArgs e)
        {
            if (pic.Width >= 10 && pic.Height >= 10)
            {
                pic.Width = Convert.ToInt32(pic.Width / 1.25);
                    pic.Height = Convert.ToInt32(pic.Height / 1.25);
            }
                else
                {
                    MessageBox.Show("Limite de tamanho mínimo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAbrir.ShowDialog(); pic.Load(ofdAbrir.FileName);
            }
            catch
            {
                MessageBox.Show("Tipo de arquivo não permitido, escolha arquivos do tipo BMP, JPEG, GIF ou PNG", "Aviso"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
