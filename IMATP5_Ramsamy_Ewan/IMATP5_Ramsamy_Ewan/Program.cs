using System;

namespace IMATP5_Ramsamy_Ewan
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodesDuProjet Outils = new MethodesDuProjet();

            Console.WriteLine("Quel est le coefficient de votre opération ?");
            int tailleMatrice = int.Parse(Console.ReadLine());

            int[,] tableau = new int[tailleMatrice, tailleMatrice];
            string affichage = "";

            Outils.RemplissageTableau(ref tableau);
            Outils.AfficherTableau(tableau, tailleMatrice, out affichage);

            Console.WriteLine("Voici Votre opération : " + affichage);
            Console.ReadLine();
        }
    }
}
