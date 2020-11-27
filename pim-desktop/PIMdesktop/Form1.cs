using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PIMdesktop
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Conexao = ("Server=DEB; Database=DBpim; User ID=sa; Password=***********; Persist Security Info=True; ");
            var connection = new MySql.Data.MySqlClient.MySqlConnection(Conexao);
            var comand = connection.CreateCommand();
            MySqlCommand query = new MySqlCommand("SELECT * FROM TBusuarios WHERE usuario = '" + textBox1.Text + "' and senha = '" + textBox2.Text + "'", connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);
            

            foreach (DataRow list in dataTable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    this.Close();
                    nt = new Thread(HomeForm);
                    nt.SetApartmentState(ApartmentState.MTA);
                    nt.Start();
                }
                else
                {
                    MessageBox.Show("Login/Senha inválidos!");
                }
            }

            connection.Close();
        }

        /* if (textBox1.Text == "admin" && textBox2.Text == "1234")
        {
            this.Close();
            nt = new Thread(HomeForm);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }
        else
        {
            MessageBox.Show("Login/Senha inválidos!");
        }
    }*/

        private void HomeForm()
        {
            Application.Run(new Home());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
