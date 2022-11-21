using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3
{
    internal class point
    {
        //declaration des variables x,y dans le plan 
        public int x { get; set; }
        private int y { get; set; }


        //initialisation des attributs 
        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //translation d'un point 
        public point Transaltion(point q) {
            point p_resulat = new point(x + q.x, y + q.y);
            return p_resulat;
        }


        //calcul de la distance entre deux points
        public double Distance(point p, point q)
        {

            double resu;
          
            resu = Math.Sqrt(Math.Pow(p.x - q.x, 2) - Math.Pow(p.y - q.y, 2));
            return resu;

        }

        // verifie si deux points sont egales 
        public bool egalite(point p, point q)
        {
          
            return ((p.x == q.x) && (p.y == q.y));
        }

        // la linearite de 3 points 

        public bool linearite (point p, point q, point k) {
          
            double cofi_direc_1 = 0; // initialisation de coefficenient directeur b 0 
            double cofi_direc_2 = 0;
            cofi_direc_1 = (p.y - q.y) / (p.x - q.x);
            cofi_direc_2 = (k.y - p.y) / (k.x - p.x);
            return (cofi_direc_1 == cofi_direc_2);



        }
    }
}
