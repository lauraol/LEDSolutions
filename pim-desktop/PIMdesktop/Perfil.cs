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
    public partial class Perfil : Form
    {
        Thread nt;
        public Perfil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(HomeForm);
            nt.SetApartmentState(ApartmentState.MTA);
            nt.Start();
        }

        private void HomeForm()
        {
            Application.Run(new Home());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
