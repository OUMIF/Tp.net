using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3.Interfaces;

namespace Tp3.Models
{
    internal class RessourcesHumaines : IRessourcesHumaines
    {
        Dictionary<Enseignant, Groupes> groupesEnseignants;

        public RessourcesHumaines()
        {
            this.groupesEnseignants = new Dictionary<Enseignant, Groupes>();
        }

        public void ajouter(Enseignant enseignant, Groupes groupe)
        {

            this.groupesEnseignants.Add(enseignant, groupe);
        }

        public void AfficherEnseignants()
        {
            if (groupesEnseignants != null)
            {
                foreach (var i in groupesEnseignants)
                {
                    Console.WriteLine($" Professeur code ={i.Key.Code}   groupe = {i.Value.Name} \n");
                }
            }
            else
                Console.WriteLine("La liste est videee !!!");

        }


        public Enseignant RechercherEns(string code)
        {
            if (groupesEnseignants.Count > 0)  
            {
                foreach (var i in groupesEnseignants)
                {
                    if (i.Key.Code.Equals(code))
                    {
                        return i.Key;
                    }
                }
            }
            return null;
        }








    }
}
