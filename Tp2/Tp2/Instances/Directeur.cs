
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Directeur
    {

        private GestionEmployes gestionEmployes;



        public Directeur(GestionEmployes gestionEmployes) {

            this.gestionEmployes = gestionEmployes;
        }


        public float afficherSalaireTotal()
        {
            return this.gestionEmployes.SommeSalaire();
        }

        public float afficherSalaireMoyen()
        {
            return this.gestionEmployes.calculerSalaireMoyen();
        }
  
    }
}
