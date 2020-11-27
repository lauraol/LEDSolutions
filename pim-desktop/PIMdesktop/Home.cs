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
    public partial class Home : Form
    {
        Thread nt;
        public Home()
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
            this.Close();
            nt = new Thread(PerfilForm);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();

        }

        private void PerfilForm()
        {
            Application.Run(new Perfil());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(CadastroForm);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void CadastroForm()
        {
            Application.Run(new Cadastro());
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(BuscaForm);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void BuscaForm()
        {
            Application.Run(new Busca());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(RelatorioForm);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void RelatorioForm()
        {
            Application.Run(new Relatorio());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(RForm1Form);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void RForm1Form()
        {
            Application.Run(new Form1());
        }
    }
}
