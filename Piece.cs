using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace YILAN_OYUNU
{ 
    class Piece : Label

    {
        public Piece (int x , int y)
        {
            Location = new System.Drawing.Point(x, y);
            Size = new System.Drawing.Size(20, 20);
            BackColor = Color.Black;
            Enabled = false;
        }
    }
}
