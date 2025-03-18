using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp3.Models;

namespace Tp3.Interfaces
{
    internal interface IRessourcesHumaines
    {

        public void AfficherEnseignants();
        public Enseignant RechercherEns(string code);
        
    }
}
