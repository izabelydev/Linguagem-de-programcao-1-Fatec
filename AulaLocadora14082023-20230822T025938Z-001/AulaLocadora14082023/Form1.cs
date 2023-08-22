using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaLocadora14082023
{
    public partial class Form1 : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblFuncionarios;
        private String strsql, strconex;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = null;
            txtsenha.Text = null;
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                strconex = "data source=(local); initial catalog=locadora; integrated security=sspi";
                conexao = new SqlConnection(strconex);
                conexao.Open();

                tblFuncionarios = new DataTable();

                strsql = "select * from funcionarios where usuario='" + txtusuario.Text.Replace("-", " ") + "' and senha ='" + txtsenha.Text.Replace("-", " ") + "'";
                //replace -> trocar/alterar
                adapter = new SqlDataAdapter(strsql, strconex);
                adapter.Fill(tblFuncionarios);

                if (tblFuncionarios.Rows.Count == 1)
                {
                    lblMsg.Text = "Login efetuado com sucesso";
                    Menu menu = new Menu();
                    menu.Nome = tblFuncionarios.Rows[0]["nomefunc"].ToString();
                    menu.Nivel = tblFuncionarios.Rows[0]["nivel"].ToString();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    lblMsg.Text = "Erro ao efetuar login, tente novamente";
                }
            }

            catch {
                MessageBox.Show("Erro de login", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
