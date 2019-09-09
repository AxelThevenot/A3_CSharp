using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD6
{
    class Commune
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            private set { nom = value; }
        }

        private int departement;
        public int Departement
        {
            get { return departement; }
            private set { departement = value; }
        }

        private string pays;
        public string Pays
        {

            get { return pays; }
            private set { pays = value; }
        }

        private string maire;
        public string Maire
        {
            get { return maire; }
            private set { maire = value; }
        }

        private int nombreHabitant;
        public int NombreHabitant
        {
            get { return nombreHabitant; }
            private set { nombreHabitant = value; }
        }

        public Commune(string _nom, int _departement, string _pays, string _maire, int _nombreHabitant)
        {
            nom = _nom.ToUpper();
            if (_departement > 0)
            {
                departement = _departement;
            }
            else
            {
                departement = -1;
            }
            pays = _pays.ToUpper();
            maire = _maire.ToLower();
            if (_nombreHabitant > 0)
            {
                nombreHabitant = _nombreHabitant;
            }
            else
            {
                nombreHabitant = -1;
            }
        }

        public override string ToString()
        {
            string description = null;
            description += "Nom de la commune : " + nom;
            description += "\nDépartement : " + departement.ToString();
            description += "\nPays : " + pays;
            description += "\nMaire : " + maire;
            description += "\nNombre d'habitant :" + nombreHabitant.ToString();
            return description;
        }

        public bool Equals(Commune _commune)
        {
            if (_commune.NombreHabitant == nombreHabitant)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Equals(Commune commune1, Commune commune2)
        {
            if (commune1.NombreHabitant == commune2.NombreHabitant)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MAJNombreHabitant(int nouveauNombreHabitant)
        {
            if (nouveauNombreHabitant > 0)
            {
                nombreHabitant = nouveauNombreHabitant;
            }
            else
            {
                nombreHabitant = -1;
            }
        }

        public void MAJMaire(string nouveauMaire)
        {
            maire = nouveauMaire.ToLower();
        }


    }
}
