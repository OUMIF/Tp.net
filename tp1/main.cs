using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class main
    {

        static void Main(string[] args)
        {
            
            Repertoire monRepertoire = new Repertoire("Documents", 0);

            
            Fichier fichier1 = new Fichier("Rapport", "pdf");
            fichier1.setTaille(2048);
            Fichier fichier2 = new Fichier("Presentation", "ppt");
            fichier2.setTaille(5120);
            Fichier fichier3 = new Fichier("CodeSource", "cs");
            fichier3.setTaille(1024);

            monRepertoire.Ajouter(fichier1);
            monRepertoire.Ajouter(fichier2);
            monRepertoire.Ajouter(fichier3);

            
            Console.WriteLine("--- Affichage du répertoire ---");
            monRepertoire.Afficher();

           
            Console.WriteLine("\nRecherche du fichier 'Rapport' :");
            int index = monRepertoire.Rechercher("Rapport");
            Console.WriteLine(index != -1 ? "Fichier trouvé à l'index : " + index : "Fichier non trouvé");

            
            Console.WriteLine("\nFichiers PDF dans le répertoire :");
            foreach (var pdf in monRepertoire.RechercherPdfs())
            {
                Console.WriteLine(pdf);
            }

           
            Console.WriteLine("\nSuppression du fichier 'Presentation'");
            if (monRepertoire.delete("Presentation"))
            {
                Console.WriteLine("Fichier supprimé avec succès.");
            }
            else
            {
                Console.WriteLine("Échec de la suppression.");
            }

           
            Console.WriteLine("\nRenommage du fichier 'CodeSource' en 'CodeFinal'");
            if (monRepertoire.Renommer("CodeSource", "CodeFinal"))
            {
                Console.WriteLine("Fichier renommé avec succès.");
            }
            else
            {
                Console.WriteLine("Échec du renommage.");
            }

            
            Console.WriteLine("\nModification de la taille du fichier 'Rapport'");
            if (monRepertoire.Modifier("Rapport", 3072))
            {
                Console.WriteLine("Taille du fichier modifiée.");
            }
            else
            {
                Console.WriteLine("Échec de la modification de la taille.");
            }

            
            Console.WriteLine("\n--- Répertoire après modifications ---");
            monRepertoire.Afficher();

            Console.ReadLine();
        }
    }


}

