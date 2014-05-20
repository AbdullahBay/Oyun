using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public class FormKontrol
    {
        int oyunAlaniLeft;
        int oyunAlaniTop;
        public FormKontrol()
        {
            //oğuz 
        }
        public FormKontrol(int oyunAlaniLeft,int oyunAlaniTop)
        {
            this.oyunAlaniLeft = oyunAlaniLeft;
            this.oyunAlaniTop = oyunAlaniTop;
        
        }
    
        public void OyunAlaniOlustur(Form form)
        {
            OyunAlani oyunAlani=new OyunAlani(400,300);
            PictureBox pbOyunAlani = new PictureBox();
            pbOyunAlani.BackColor = Color.Aqua;
            pbOyunAlani.Height = oyunAlani.Yukseklik;
            pbOyunAlani.Width = oyunAlani.Genislik;
            pbOyunAlani.Left = oyunAlaniLeft;
            pbOyunAlani.Top = oyunAlaniTop;
            form.Controls.Add(pbOyunAlani);

        }
    }
}
