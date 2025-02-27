using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Employee
    {

        private string nom;
        private float salaire;
        private string poste;
        private string date;
       

        
        
        
        public Employee(string nom, float salaire, string poste, string date)
        {
            this.nom = nom;
            this.Salaire = salaire;
            this.Poste = poste;
            this.date = date;
           
        
        }






        public string Date { get => date; set => date = value; }
        public string Poste { get => poste; set => poste = value; }
        public float Salaire { get => salaire; set => salaire = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
