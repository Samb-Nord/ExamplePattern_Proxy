using ClassLibrary_Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProxy
{
    public partial class FormCompte : Form
    {
        private AuthentificationProxy proxy;

        public FormCompte()
        {
            InitializeComponent();
        }

        public FormCompte(AuthentificationProxy _proxy) : this()
        {

            proxy = _proxy;
            labelSolde.Text = _proxy.Compte.Solde.ToString() + "€";
        }

        private void buttonDebiter_Click(object sender, EventArgs e)
        {
            Double.TryParse(textBoxDebit.Text, out double montantDebit);
            if (this.proxy.Debiter(montantDebit))
            {
                MessageBox.Show("Opération réussie");
                labelSolde.Text = proxy.Compte.Solde.ToString() + "€";

            }
            else
            {
                MessageBox.Show("Echec");
            }
            textBoxDebit.Clear();
        }

        private void buttonCrediter_Click(object sender, EventArgs e)
        {
            Double.TryParse(textBoxCredit.Text, out double montantCredit);
            if (this.proxy.Crediter(montantCredit))
            {
                MessageBox.Show("Opération réussie");
                labelSolde.Text = proxy.Compte.Solde.ToString() + "€";

            }
            else
            {
                MessageBox.Show("Echec");
            }
            textBoxCredit.Clear();
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
