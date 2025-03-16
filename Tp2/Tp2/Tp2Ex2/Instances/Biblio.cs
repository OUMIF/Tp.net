using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2Ex2.Instances
{
    internal class Biblio
    {
        List<Documents> documents;

        public Biblio()
        {
            documents = new List<Documents>();
        }



        public bool ajouterDoc(Documents document)
        {
       
            if (documents != null)
            {
                documents.Add(document);
                return true;
            }
            else
                return false;

        }

        public int countLivres()
        { 
            int count = 0;
            foreach(var i  in documents)
            {
                if (i is Livre)
                    count++;
            }
            return count;
        }

        public void AfficherDictionnaire()
        {
            foreach(var i in documents)
            {
                if (i is Dictionaire dict)
                {
                    Console.WriteLine("titre = " + dict.GetTitre() + "langue = " + dict.GetLangue());
                }
            }
        }
    
        public void tousLesAuteurs() {
            foreach(var i in documents)
            {
                if (i is Livre livre)
                Console.WriteLine($"numero document = {livre.getNumeroDoc()}, Auteur = {livre.GetNomAuteur()}\n" );
                else
                    Console.WriteLine($"numero document = {i.getNumeroDoc()}, Auteur = Aucun \n");
            }
           
        }

        public void toutesLesDescriptions()
        {
            foreach(var i in documents)
            {
                Console.WriteLine($"{i.description()}");
            }
        }







    }
}
