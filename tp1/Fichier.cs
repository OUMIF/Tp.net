using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{
    internal class Fichier
    {
        private String Nom;
        private String Extension;
        private float Taille = 0;



        public Fichier(String Nom, String Extension)
        {
            this.Nom = Nom;
            this.Extension = Extension;
        }



        public String getNom()
        {
            return Nom;
        }
        public String getExtension()
        {
            return Extension;
        }
        public float getTaille()
        {
            float tailleMega = Taille * 0.001f;
            return (tailleMega);
        }
        public  void setNom(String Nom)
        {
            this.Nom = Nom;
        }
        public void setExtension(String Extension)
        {
            this.Extension = Extension;
        }
        public void setTaille(float Taille)
        {
            this.Taille = Taille;
        }



    }
}
