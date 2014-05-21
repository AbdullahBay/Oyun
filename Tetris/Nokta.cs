using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    
        public class Nokta
        {
            private int x;

            public int X
            {
                get { return x; }
                set { x = value; }
            }
            private int y;

            public int Y
            {
                get { return y; }
                
                set { y = value; }
            }
            public Nokta(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
            public Nokta(Nokta nokta)
            {
                x = nokta.x;
                y = nokta.y;
            }
            
        }
    
}
