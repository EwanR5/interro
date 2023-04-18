using System;
using System.Collections.Generic;
using System.Text;

namespace IMATP5_Ramsamy_Ewan
{
    public struct MethodesDuProjet
    {
        public void RemplissageTableau(ref int[,] tableau)
        {
            tableau[0, 0] = 1;

            for (int i = 1; i < tableau.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < tableau.GetLength(1) - 1; j++)
                {
                    if (j == 0)
                    {
                        tableau[i, j] = 1;
                    }
                    else
                    {
                        tableau[i, j] = tableau[i - 1, j - 1] + tableau[i - 1, j];
                    }
                }
            }
        }
        public void AfficherTableau(int[,] tableau, int tailleMatrice, out string affichage)
        {
            affichage = "a" + ^tailleMatrice;
            int exposantA = tailleMatrice - 1;
            int exposantB = 1;

            for (int j = 0; j < tableau.GetLength(1) - 2; j++)
            {
                affichage = affichage + tableau[tailleMatrice, j] + "a" + ^exposantA + "b" + ^exposantB;
                exposantA = exposantA - 1;
                exposantB = exposantB + 1;
            }
            affichage = affichage + "b" + ^exposantB;
        }
    }
}
