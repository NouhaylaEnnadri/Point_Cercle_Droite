using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3
{
    internal class droite
    {
        private object pointB;
        private object pointA;

        private point p { get; set; }   
        private point q { get; set; }    

        public droite(point p, point q)
        {
            this.p = p;
            this.q = q;
        }

        public bool egalite(droite d1, droite d2)
        {
            return ((d1.p == d2.q) && (d1.p == d2.q));
        }
        public bool intersection(droite d1, droite d2)
        {
            return ((d1.p == d2.q) && (d1.p == d2.q));
        }
        public bool Parallelisme(droite d)
        {
            return (d.p == p.Transaltion(p) && d.q == q.Transaltion(q));

        }

        public bool Intersection(droite d)
        {
            double c1 = (q.y - p.y) / (p.x - q.y);
            double c2 = ((d.q.y - d.p.y) / (d.q.x - d.p.x));

            return c1 != c2;
        }
    }
}
