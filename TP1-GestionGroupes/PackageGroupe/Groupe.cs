using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1_GestionGroupes.PackageGroupe
{
    public class Groupe
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public Groupe(int id, string nom) {
            this.id = id;
            this.nom = nom;
        }

        public Groupe()
        {
           
        }
    }
}
