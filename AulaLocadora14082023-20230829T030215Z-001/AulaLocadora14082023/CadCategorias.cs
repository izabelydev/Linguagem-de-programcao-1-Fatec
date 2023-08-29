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
    public partial class CadCategorias : Form
    { 
        private SqlConnection conexao;//gravar os dados da tabela 
        private SqlCommand comando;//gravar os dados da tabela
        private string strSql, strConex;

        public CadCategorias()
        {
            InitializeComponent();
        }

        private void CadCategorias_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e) //gravar
        {
            try
            {
                strConex = "data source=(local);initial catalog=locadora; integrated security=sspi";
                conexao = new SqlConnection(strConex);
                conexao.Open();

                strSql = "insert into categorias (categoria, descricao, valor) values ('" + txtCategoria.Text + "', '" + txtDescricao.Text + "', '" + txtValor.Text.Replace(",", ".") + "')";
                comando = new SqlCommand(strSql, conexao);
                comando.ExecuteNonQuery();
                lblMsg.Text = "Registro gravado com sucesso";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro nos dados digitados. " + ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void Button2_Click(object sender, EventArgs e) //cancelar
        {

        }

    }
}
