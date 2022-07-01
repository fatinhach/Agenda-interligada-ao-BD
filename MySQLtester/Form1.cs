using MySql.Data.MySqlClient;

namespace MySQLtester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

            private void cmdInserir_Click(object sender, EventArgs e)
            {

            Inserir_Um_Novo_Contato j1 = new Inserir_Um_Novo_Contato();
            j1.Show();
                

            }

            private void button1_Click(object sender, EventArgs e)

            {
            Deletar j2 = new Deletar();
            j2.Show();
            
            }

            private void button2_Click(object sender, EventArgs e)
            {
            Exibir_Agenda j3 = new Exibir_Agenda();
            j3.Show();
            }
    }
    
    }
