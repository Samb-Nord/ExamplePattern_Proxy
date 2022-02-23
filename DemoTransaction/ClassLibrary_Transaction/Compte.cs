using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Transaction
{
    public class Compte : ITransaction
    {
        private double solde;
        private string identifiant;

        public double Solde { get => solde; private set => solde = value; }
        public string Identifiant { get => identifiant; private set => identifiant = value; }

        public Compte(double _solde, string _id)
        {
            solde = _solde;
            identifiant = _id;
        }

        /// <summary>
        /// Retirer un montant du compte
        /// </summary>
        /// <param name="montantDebit"></param>
        /// <returns></returns>
        public bool Debiter(double montantDebit)
        {
            bool success = false;

            //si le montant de prélèvement est supérieur au solde et n'est pas <= 0
            //je n'autorise pas le découvert
            if(montantDebit <= solde && montantDebit > 0)
            {
                solde -= montantDebit;
                success = true;
            }

            return success;
        }

        /// <summary>
        /// déposer un montant sur le compte
        /// </summary>
        /// <param name="montantCredit"></param>
        /// <returns></returns>
        public bool Crediter(double montantCredit)
        {
            bool success = false;
            //il faut que le montant à déposer ne soit pas égal ou inférieur à 0
            if (montantCredit > 0)
            {
                solde += montantCredit;
                success = true;
            }

            return success;
        }
    }
}
