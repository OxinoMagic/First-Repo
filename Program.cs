using System;
using System.Xml;

namespace Calculatrice2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //demande prénom
            System.Console.WriteLine("Saisir Prénom: ");
            string prenom = Console.ReadLine();
            System.Console.WriteLine("Coucou " + prenom);

            //Demande sexe
            System.Console.WriteLine("Es-tu un Homme ou une Femme ? (h/f)");
            char sexe = Convert.ToChar(Console.ReadLine());
            while (sexe != 'h' && sexe != 'f')
            {
                System.Console.WriteLine("Frerot tu t'es trompé recommence:");
                sexe = Convert.ToChar(Console.ReadLine());
            }

            //demande âge
            System.Console.WriteLine("Quel âge as tu ?");

            int age = Convert.ToInt16(Console.ReadLine());

            if (age >= 18)
            {
                System.Console.WriteLine("tu est majeur tu peux voir tout les video");
            }
            else
            {
                System.Console.WriteLine("tu est mineur va regarder les télétubies");
            }
            for (int i = 1; i <= age; i++)
            {
                Console.Write(i);
            }
        }
    }
}