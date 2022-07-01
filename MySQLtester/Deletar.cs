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
    public partial class Deletar : Form
    {
        public Deletar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(MySqlConnection cnn = new MySqlConnection())

                {
                 //Realiza a conexão
                 cnn.ConnectionString = "server=localhost;database=agenda;uid=root;pwd=Brasil23;port=3306";
                 cnn.Open();

                 //comando sql para inserir dados
                 MySqlCommand objcmd = new MySqlCommand("DELETE FROM dados WHERE nome = ?;", cnn);
                    
                 //parametros
                 objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = textnome2.Text;


                 // comando para escrever e executar a query
                 objcmd.ExecuteNonQuery();

                 //fecha conexão
                 cnn.Close();

                 MessageBox.Show("O Contato foi Deletado com sucesso!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
