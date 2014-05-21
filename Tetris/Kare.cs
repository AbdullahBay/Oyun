using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public class Kare
    {
        StaticVeriler.Yon yon;
        PictureBox picturebox;
        System.Drawing.Color renk;
        Nokta n1, n2;
        int kenar;
        private int bagliOlduguKareIndisi;
        public int BagliOlduguKAreIndisi
        {
            get { return bagliOlduguKareIndisi; }
            set { bagliOlduguKareIndisi = value; }
        }

        public Kare(Nokta Merkez, int kenar, System.Drawing.Color renk=System.Drawing.Color.Red,int bagliOlduguKareninIndisi=0)
        {
            this.kenar = kenar;
            n1 = new Nokta(Merkez);
            n2 = new Nokta(Merkez.X + kenar, Merkez.Y - kenar);
            this.bagliOlduguKareIndisi = bagliOlduguKareIndisi;
            picturebox = new PictureBox();
            //renk=System.Drawing.Color.Red;
            picturebox.BackColor =renk ;
          
        }
        
               
        //olusan sekli sola döndüğünde noktaların alacağı konumu belirler
        public void Dondur()
        {
            if(n1.X<n2.X&&n1.Y>n2.Y)
            { 
                n1.Y = n1.Y - kenar;
                n2.Y = n2.Y + kenar;
            }
            if(n1.X<n2.X&&n1.Y<n2.Y)
            { 
                n1.X = n1.X + kenar;
                n2.X = n2.X - kenar;
            }
            if(n1.X>n2.X&&n1.Y<n2.Y)
            { 
                n1.Y = n1.Y + kenar;
                n2.Y = n2.Y - kenar;
            }
            if(n1.X>n2.X&&n1.Y>n2.Y)
            { 
                n1.X = n1.X - kenar;
                n2.X = n2.X + kenar;
            }
        }

        //noktalardaki verileri görsel nesneye yükler ve gösterilmesi için forma Ekler.
        public void Goster()
        {
            picturebox.Height = kenar;
            picturebox.Width = kenar;
            picturebox.Top = n1.Y;
            picturebox.Left = n1.X;
        }
        public void formaEkle(Form form)
        {
            Goster();
            form.Controls.Add(picturebox);
        }
    }
}
