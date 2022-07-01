using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLtester
{
    public partial class Inserir_Um_Novo_Contato : Form
    {
        public Inserir_Um_Novo_Contato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection())
                {
                 //abre a conexão 
                 cnn.ConnectionString = "server=localhost;database=agenda;uid=root;pwd=Brasil23;port=3306";
                 cnn.Open();

                 //comando sql para inserir dados
                 MySqlCommand objcmd = new MySqlCommand("insert into dados (codigo, nome, numero) values (null, ?, ?);", cnn);
                 
                 //parametros
                 objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = textnome1.Text;
                 objcmd.Parameters.Add("@numero", MySqlDbType.VarChar, 21).Value = texttelefone.Text;

                 // comando para escrever e executar a query
                 objcmd.ExecuteNonQuery();

                 //fecha conexão
                 cnn.Close();

                 MessageBox.Show("Novo Contato Inserido com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" +ex);
            }
        }
    }
}
