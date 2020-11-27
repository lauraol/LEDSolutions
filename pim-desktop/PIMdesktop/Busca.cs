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
    public partial class Busca : Form
    {
        Thread nt;
        public Busca()
        {
            InitializeComponent();
        }

        private void tBclientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tBclientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBpimDataSet);

        }

        private void Busca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBpimDataSet.TBclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tBclientesTableAdapter.Fill(this.dBpimDataSet.TBclientes);

        }

        private void tBclientesBindingNavigator_RefreshItems(object sender, EventArgs e)
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
    }
}
