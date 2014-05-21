using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public class Kare : Nokta 
    {
        public Kare()
        { }
        Nokta Nokta1, Nokta2;
        StaticVeriler.Yon yon;
        PictureBox picturebox;
        System.Drawing.Color renk;
        int kenar;

        private int[][] nokta;
        //olusan sekli sola döndüğünde noktaların alacağı konumu belirleyecek.Ve
        public void Dondur(Nokta n1, Nokta n2)
        {
            if(n1.x<n2.x&&n1.y>n2.y)
            { n1.y = n1.y - kenar;
              n2.y = n2.y + kenar}
            if(n1.x<n2.x&&n1.y<n2.y)
            { n1.x = n1.x + kenar;
              n2.x = n2.x - kenar}
            if(n1.x>n2.x&&n1.y<n2.y)
            { n1.y = n1.y + kenar;
              n2.y = n2.y - kenar}
            if(n1.x>n2.x&&n1.y>n2.y)
            { n1.x = n1.x - kenar;
              n2.x = n2.x + kenar}

            olustur();
        }

        //noktaları verilmiş karelerden şekil oluşturur.
        public void olustur()
        {
            throw new System.NotImplementedException();
        }
    
        
    }
}
