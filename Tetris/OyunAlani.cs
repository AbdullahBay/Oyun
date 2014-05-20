using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class OyunAlani
    {
        private Taban taban;
        private Sekil sekil;
        private int yukseklik;
        // abdullah
        public int Yukseklik
        {
            get { return yukseklik; }
            set { yukseklik = value; }
        }
        private int genislik;

        public int Genislik
        {
            get { return genislik; }
            set { genislik = value; }
        }
        private int KareKenarUzunlugu;

        public OyunAlani(int yukseklik,int genislik)
        {
            this.yukseklik = yukseklik;
            this.genislik = genislik;
        }

       

        public void KenarKontrol()
        {
            
        }
    }
}
