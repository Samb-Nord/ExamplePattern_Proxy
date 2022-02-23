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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string identifiant = maskedTextBoxIdentifiant.Text;
            AuthentificationProxy proxy = new AuthentificationProxy(identifiant);

            if (proxy.IsValid)
            {
                FormCompte windowCompte = new FormCompte(proxy);
                windowCompte.ShowDialog();
                maskedTextBoxIdentifiant.Clear();
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas y accéder");
            }
        }
    }
}
