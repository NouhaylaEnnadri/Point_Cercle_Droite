using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3
{
    internal class point
    {
        private int x; 
        private int y;

        public point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int Getx()
        {
            return x;   
        }
        public int Gety()
        {
            return y;
        }
        public void Setx(int x )
        {
            this.x = x; 
        }
        public void Sety( int y)
        {
            this.y = y;
        }
        
        public point Transaltion(point q) {
         point p_resulat = new point (x+q.x , y+q.y);
            return p_resulat;
           

        }

      public int Distance(point p , point q)
        {

            int resu; 
            q = new point (x,y);
            p= new point(x, y);
            resu = (int)Math.Sqrt( Math.Pow(p.x-q.x,2) - Math.Pow(p.y-q.y,2) ); 
            return resu; 

        }

    }
}
