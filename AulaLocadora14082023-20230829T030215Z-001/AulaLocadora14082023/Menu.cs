using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaLocadora14082023
{
    public partial class Menu : Form
    {
        public string Nome, Nivel;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close(); fecha o formulário
            Application.Exit(); //fecha o programa
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCategorias cat = new CadCategorias();
            cat.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Olá Sr(a). " + Nome;
            if (Nivel == "1")
            {
                excluirToolStripMenuItem.Visible = false;
                alterarToolStripMenuItem.Visible = false;
            }
            else if (Nivel == "2")
            {
                excluirToolStripMenuItem.Visible = false;
            }
        }
    }
}
