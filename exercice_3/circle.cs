using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3
{
    internal class circle
    {
        class Cercle
        {
            public point centre { get; set; }   
            public int rayon { get; set; }  

         
            public Cercle(point centre, int rayon = 0)
            {
                centre = new point(0, 0);
                this.centre = centre;
                this.rayon = rayon;
            }
            public double Area (double r)
            {
                double air = Math.PI * r * r;

                return air ;
            }
           
        }
}
