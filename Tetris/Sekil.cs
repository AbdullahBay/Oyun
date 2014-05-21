using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Sekil:ISekil
    {
        //deneme
        private int maxKareSayisi;
        Kare[] kareler=new Kare [5];
        private int kareSayisi;
        int kenar;
    
        Sekil() {

            maxKareSayisi = 5;
            kareSayisi = 0;
        }
        

        public bool kareEkle(StaticVeriler.Yon yon , Nokta Merkez)
        {
            if(maxKareSayisi<=kareSayisi)
            {
                return false;
            }
            kareler[kareSayisi] = new Kare(Merkez,kenar);
            return true;
            kareSayisi++;            
        }







        public abstrack bool olustur()
        {
            
        }
    }
}
