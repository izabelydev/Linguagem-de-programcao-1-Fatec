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
    public partial class cadCliente : Form
    {
        private SqlConnection conexao;//gravar os dados da tabela 
        private SqlCommand comando;//gravar os dados da tabela
        private string strSql, strConex;

        public cadCliente()
        {
            InitializeComponent();
        }

        private void BtConcluir_Click(object sender, EventArgs e)
        {
            strConex = "data source=(local);initial catalog=locadora; integrated security=sspi";
            conexao = new SqlConnection(strConex);
            conexao.Open();

            strSql = "insert into clientes (categoria, descricao, valor) values ('" + txtCategoria.Text + "', '" + txtDescricao.Text + "', '" + txtValor.Text.Replace(",", ".") + "')";
            comando = new SqlCommand(strSql, conexao);
            comando.ExecuteNonQuery();
            lblMsg.Text = "Registro gravado com sucesso";
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
