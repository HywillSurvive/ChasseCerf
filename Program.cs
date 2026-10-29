namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */

        
        int nombreFlèche = 5;
        int nombreTouche = 0;
        
        Console.WriteLine("Arthur chasse un cerf avec son arc, mais il n'a que 5 flèches.");

        while (nombreTouche < 3 && nombreFlèche > 0)
        {

            Console.WriteLine("Est-ce que la flèche " + nombreFlèche + " touche la cible? \nTapez 1 pour oui et 0 pour non.");
            int touche = Convert.ToInt32(Console.ReadLine());

            if (touche == 1)
            {
                nombreTouche++;
                nombreFlèche--;
                Console.WriteLine("Arthur à touché le cerf " + nombreTouche + " fois et il lui reste " + nombreFlèche + " flèche.");
            }

            else if (touche == 0)
            {
                nombreFlèche--;
                Console.WriteLine("Arthur à raté sa cible et il lui reste " + nombreFlèche + " flèche.");
            }

            else
            {
                Console.WriteLine("Arthur n'a pas tiré.");
            }


        }
        if (nombreTouche == 3)
        {
            Console.WriteLine("\nLe cerf est abattu !");
            Console.WriteLine("\n===== BILAN DE LA CHASSE ===== \nTirs réussis : " + nombreTouche + " \nFlèches restantes : " + nombreFlèche + " \nRésultat : chasse réussie ! ");
        }
        else
        {
            Console.WriteLine("\n===== BILAN DE LA CHASSE ===== \nTirs réussis : " + nombreTouche + " \nFlèches restantes : " + nombreFlèche + " \nRésultat : chasse ratée ! ");
        }

    }
}