using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2Ex2.Instances
{
    internal class Program
    {
    


        static void Main()
        {
            
            Documents doc1 = new Documents("Document A");
           // Console.WriteLine($"Document créé : {doc1.GetTitre()}");

            
            Livre livre1 = new Livre("Les Misérables", "Victor Hugo", 1200);
           // Console.WriteLine($"Livre : {livre1.GetTitre()}, Auteur : {livre1.GetNomAuteur()}, Pages : {livre1.GetNombrePages()}");

          
            livre1.setNomAuteur("Hugo Victor");
            livre1.setNombrePages(1250);
           // Console.WriteLine($"Livre modifié : {livre1.GetTitre()}, Auteur : {livre1.GetNomAuteur()}, Pages : {livre1.GetNombrePages()}");

           
            Dictionaire dict1 = new Dictionaire("Français", 50000, "Dictionnaire Larousse");
           // Console.WriteLine($"Dictionnaire : {dict1.GetTitre()}, Langue : {dict1.GetLangue()}, Définitions : {dict1.GetNombreDefinitions()}");

            
            dict1.SetLangue("Anglais");
            dict1.SetNombreDefinitions(60000);
            //Console.WriteLine($"Dictionnaire modifié : {dict1.GetTitre()}, Langue : {dict1.GetLangue()}, Définitions : {dict1.GetNombreDefinitions()}");

            
            //Console.WriteLine($"Nombre total d'enregistrements : {Documents.GetNombreEnregistrements()}");
            Dictionaire dict2 = new Dictionaire("Anglais",60000,"Dictionnaire la rochelle");

            Biblio biblio = new Biblio();
            biblio.ajouterDoc(dict1);
            biblio.ajouterDoc(livre1);
            biblio.ajouterDoc(dict2);
            biblio.AfficherDictionnaire();
            int c = biblio.countLivres();
            Console.WriteLine("NBR LIVRES = " +c);
            biblio.tousLesAuteurs();
            Console.WriteLine("*****Les descriptions*****");
            biblio.toutesLesDescriptions(); 
        }
    }




}

