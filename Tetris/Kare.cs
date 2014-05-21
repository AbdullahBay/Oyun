using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public class Kare
    {
        public Kare(Nokta Merkez, int kenar)
        {
            this.kenar = kenar;
            n1 = new Nokta(Merkez);
            n2 = new Nokta(Merkez.X + kenar, Merkez.Y - kenar);
            bagliOlduguKAreIndisi = 0;
          
        }
        Nokta n1, n2;
        int bagliOlduguKAreIndisi;

        public int BagliOlduguKAreIndisi
        {
            get { return bagliOlduguKAreIndisi; }
            set { bagliOlduguKAreIndisi = value; }
        }
        StaticVeriler.Yon yon;
        PictureBox picturebox;
        System.Drawing.Color renk;
        int kenar;
        
        //olusan sekli sola döndüğünde noktaların alacağı konumu belirleyecek.Ve
        public void Dondur()
        {
            if(n1.X<n2.X&&n1.Y>n2.Y)
            { 
                n1.Y = n1.Y - kenar;
                n2.Y = n2.Y + kenar;
            }
            if(n1.X<n2.X&&n1.Y<n2.Y)
            { n1.X = n1.X + kenar;
              n2.X = n2.X - kenar;}
            if(n1.X>n2.X&&n1.Y<n2.Y)
            { n1.Y = n1.Y + kenar;
              n2.Y = n2.Y - kenar;}
            if(n1.X>n2.X&&n1.Y>n2.Y)
            { n1.X = n1.X - kenar;
            n2.X = n2.X + kenar;
            }

            //olustur();
        }

        //noktaları verilmiş karelerden şekil oluşturur.
        public void ekle(Form form)
        {
            picturebox = new PictureBox();
            picturebox.Height = kenar;
            picturebox.Width = kenar;
            picturebox.Top = n1.Y;
            picturebox.Left = n1.X;
            form.Controls.Add(picturebox);
        }
    
        // denem
    }
}
