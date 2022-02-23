using ClassLibrary_Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ColorText("Entrez votre identifiant", ConsoleColor.Magenta);
            string identifiant = Console.ReadLine();
            AuthentificationProxy proxy = new AuthentificationProxy(identifiant);

            if (proxy.IsValid)
            {
                do
                {
                    ColorText("------------------------------", ConsoleColor.Magenta);
                    ColorText("Entrez votre Choix : 1 - Créditer, 2 - Débiter, 3 - Consulter", ConsoleColor.Blue);
                    Int32.TryParse(Console.ReadLine(), out int choix);
                    switch (choix)
                    {
                        case 1:
                            ColorText("le montant à créditer : ", ConsoleColor.Yellow);
                            Double.TryParse(Console.ReadLine(), out double montantCredit);
                            if (proxy.Crediter(montantCredit))
                            {
                                ColorText("Opération effectuée", ConsoleColor.Green);
                                ColorText($"Votre solde est de : {proxy.Compte.Solde}€", ConsoleColor.Cyan);
                            }
                            else
                            {
                                ColorText("Opération échouée", ConsoleColor.Red);
                            }
                            break;
                        case 2:
                            ColorText("le montant à prélever : ", ConsoleColor.Yellow);
                            Double.TryParse(Console.ReadLine(), out double montantDebit);
                            if (proxy.Debiter(montantDebit))
                            {
                                ColorText("Opération effectuée", ConsoleColor.Green);
                                ColorText($"Votre solde est de : {proxy.Compte.Solde}€", ConsoleColor.Cyan);
                            }
                            else
                            {
                                ColorText("Opération échouée", ConsoleColor.Red);
                            }
                            break;
                        case 3:
                            ColorText($"Votre solde est de : {proxy.Compte.Solde}€", ConsoleColor.Magenta);
                            break;

                    }
                } while (true);
            }
            else
            {
                Console.WriteLine("Identifiant incorrect");
            }


            Console.ReadLine();
        }

        public static void ColorText(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message); 
        }
    }
}
