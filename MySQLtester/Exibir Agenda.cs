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
    public partial class Exibir_Agenda : Form
    {
        public Exibir_Agenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                 MySqlCommand objcmd = new MySqlCommand("select codigo, numero from dados where nome = ?;", cnn);
                 
                 //parametros
                 objcmd.Parameters.Clear();
                 objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = textnome.Text;

                 // executa o comando
                 objcmd.CommandType = CommandType.Text;

                 // recebe o contéudo que vem do BD
                 MySqlDataReader fit;
                 fit = objcmd.ExecuteReader();
                 fit.Read();

                 textcodigo.Text = fit.GetString(0);
                 texttelefone.Text = fit.GetString(1);

                 //fecha conexão
                 cnn.Close();

                 MessageBox.Show("Pesquisa Realizada com Sucesso!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection())
                {
                 //abre a conexão
                 cnn.ConnectionString = "server=localhost;database=agenda;uid=root;pwd=Brasil23;port=3306";
                 cnn.Open();

                 //comando sql para inserir dados
                 MySqlCommand objcmd = new MySqlCommand("UPDATE dados SET nome= ?, numero= ? WHERE codigo = ?;", cnn);
                 
                 //parametros das declarações
                 objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = textnome.Text;
                 objcmd.Parameters.Add("@numero", MySqlDbType.VarChar, 50).Value = texttelefone.Text;
                 objcmd.Parameters.Add("@codigo", MySqlDbType.Int32).Value = textcodigo.Text;


                 // comando para escrever e executar a query
                 objcmd.CommandType = CommandType.Text;
                 objcmd.ExecuteNonQuery();

                 //fecha conexão
                 cnn.Close();

                 MessageBox.Show("Atualização realizada com sucesso!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
