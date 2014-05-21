using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public abstract class Sekil
    {
        //deneme
        private int maxKareSayisi;
        Kare[] kareler=new Kare [5];
        private int kareSayisi;
        int kenar;
        public Sekil()
        {
            maxKareSayisi = 5;
            kenar = 20;
        }
    
       
        

        public bool kareEkle(StaticVeriler.Yon yon , Nokta Merkez)
        {
            if(maxKareSayisi<=kareSayisi)
            {
                return false;
            }
            kareler[kareSayisi] = new Kare(Merkez,kenar);
            
            kareSayisi++;
            return true;            
        }
        







        public abstract bool olustur();

        public void Goster(Form form)

        {
            for (int i = 0; i < kareSayisi; i++)
            {
                kareler[i].Goster(form);
            }
        }

    }
}
