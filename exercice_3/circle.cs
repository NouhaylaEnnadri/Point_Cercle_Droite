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
            private point centre;
            private int rayon;

            public int GetRayon()
            {
                return rayon;
            }
            public point GetCentre()
            {
                return centre;
            }
            public void SetRayon(int rayon)
            {
                this.rayon = rayon;
            }
            public void SetCenter(point centre)
            {
                this.centre = centre;
            }
            public Cercle(point centre, int rayon = 0)
            {
                centre = new point(0, 0);
                this.centre = centre;
                this.rayon = rayon;
            }
        }
    }
}
