using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Transaction
{
    public class AuthentificationProxy : ITransaction
    {
        //proxy qui sert à authentifier l'utilisateur pour vérifier qu'il a bien accès à on compte
        private Compte compte;
        private string identifiant;

        public bool IsValid { get; set; }
        public Compte Compte { get => compte; private set => compte = value; }

        public AuthentificationProxy(string _identifiant)
        {
            compte = new Compte(555, "mickey237");

            identifiant = _identifiant;
            IsValidAuthentification();
        }

        /// <summary>
        /// si l'authentification est valide le proxy fait appel à l'opération de l'objet de la classe Compte
        /// </summary>
        /// <param name="montantCredit"></param>
        /// <returns></returns>
        public bool Crediter(double montantCredit)
        {

            if (IsValid)
            {
                //peut retourner false si le montant entré <=0
                return compte.Crediter(montantCredit);
            }
            else
            {
                return false;
            }
        }

        public bool Debiter(double montantDebit)
        {

            if (IsValid)
            {
                return compte.Debiter(montantDebit);
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// return true si bon identifiant sinon return false
        /// </summary>
        private void IsValidAuthentification()
        {
            IsValid = (compte.Identifiant == identifiant) ? true : false;
        }
    }
}
