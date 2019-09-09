using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD6
{
    class Region
    {
        private string prefet;
        public string Prefet
        {
            get { return prefet; }
            set { prefet = value; }
        }

        private string chefLieu;
        public string ChefLieu
        {
            get { return chefLieu; }
            set { chefLieu = value; }
        }

        private Commune[] commune;
        public Commune[] Commune
        {
            get { return commune; }
            set { commune = value; }
        }

        public override string ToString()
        {
            string description = null;
            description += "Prefet de la région: " + prefet;
            description += "\nChef-Lieu : " + chefLieu;
            if (commune != null && commune.Length > 0)
            {
                description += "\nListe des communes : ";
                for (int i = 0; i < commune.Length; i++)
                {
                    description += "\n- " + commune[i].Nom;
                }
            }
            else
            {
                description += "\nIl n'y a pas de commune dans la région";
            }
            return description;
        }

        public int NombreHabitant()
        {
            int nombreHabitant = 0;
            if (commune != null && commune.Length > 0)
            {
                for (int i = 0; i < commune.Length; i++)
                {
                    if (commune[i].NombreHabitant != -1)
                    {
                        nombreHabitant += commune[i].NombreHabitant;
                    }
                }
            }
            return nombreHabitant;
        }

        public bool EstDansRegion(string nom)
        {
            bool estDansRegion = false;
            if (commune != null && commune.Length > 0)
            {
                for (int i = 0; i < commune.Length; i++)
                {
                    if (commune[i].Nom == nom)
                    {
                        estDansRegion = true;
                    }
                }
            }
            return estDansRegion;
        }

        public void TrierCommunes()
        {
            bool faireLeTri = true;
            if (commune != null && commune.Length > 0)
            {
                for (int i = 0; (!faireLeTri) && i < commune.Length - 1; i++)
                {
                    faireLeTri = false;
                    if (Comparer(commune[i].Nom, commune[i + 1].Nom) == 2)//si une valeur du commune est supérieure à sa suivante, on les intervertie
                    {
                        Commune z = new Commune(commune[i].Nom, commune[i].Departement, commune[i].Pays, commune[i].Maire, commune[i].NombreHabitant);
                        commune[i] = commune[i + 1];
                        commune[i + 1] = z;
                        faireLeTri = true;
                    }
                }
            }
        }



        public static int Comparer(string s1, string s2)
        {
            int compare = -1;
            if (s1 != null && s2 != null && s1.Length > 0 && s2.Length > 0)
            {
                int i = 0;
                while (i < s1.Length && i < s2.Length && s1[i] == s2[i])
                {
                    i++;
                }
                if (i == s1.Length - 1)
                {
                    if (i != s2.Length - 1)
                    {
                        compare = 1;
                    }
                }
                else if (i == s2.Length - 1)
                {
                    compare = 2;
                }
                else if ((int)s1[i] < (int)s2[i])
                {
                    compare = 1;
                }
                else
                {
                    compare = 2;
                }
            }
            return compare;

        }
    }
}
