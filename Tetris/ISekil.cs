using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    public interface ISekil
    {
        //deneme
        private int maxKareSayisi;
        private Kare[] kareler=new Kare [5];
        private int kareSayisi;
        private int kenar;
    
        
        public abstract void olustur();

        public bool kareEkle(StaticVeriler.Yon yon , Nokta Merkez);
    }
}
