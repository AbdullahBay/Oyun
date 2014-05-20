using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    public class Taban
    { 
        int satir;
        int sutun;
       
        Taban(int satir,int sutun)
        {
            this.satir= satir;
            this.sutun= sutun;
        }
         public Kare[][] kareler;

         public Boolean CarpismaKontrol(Sekil sekil)
         {
             return true;
         }

         public void TabanaEkle(Sekil sekil)
         {
             throw new System.NotImplementedException();
         }

         public void PatlamaKontrol()
         {
             throw new System.NotImplementedException();
         }
    }
}
