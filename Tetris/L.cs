using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    public class L:Sekil
    {

        public override bool olustur()
        {
            kareEkle(StaticVeriler.Yon.Merkez, new Nokta(80, 80));
            
            return true;
        }
    }
}
