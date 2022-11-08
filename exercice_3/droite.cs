using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3
{
    internal class droite
    {
        private point p ;
        private point q; 

        public droite(point p, point q)
        {
            this.p = p;
            this.q = q;
        }

        public point Getp()
        {
            return p;
        }
        public point Getq()
        {
            return q;
        }
        public void Setp(point p)
        {
            this.p = p;
        }
        public void Setq(point q)
        {
            this.q = q;
        }

    }
}
