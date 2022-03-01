using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_TriV2._View
{
    public class DisplaySorting : PictureBox
    {
        private int _maxRectangle = 20;

        private Random rnd = new Random();

        private List<_View.Rectangle> _rectangles = new List<_View.Rectangle>();

        public List<Rectangle> Rectangles { get => _rectangles; set => _rectangles = value; }

        public DisplaySorting()
        {
            //Itiliatize all the random rectangle
            for (int i = 1; i < _maxRectangle; i++)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                // Check if color already exist in our list of rectangle
                foreach (Rectangle rectangle in Rectangles)
                {

                    if(rectangle.CurrentColor == randomColor )
                    {
                        i-=1;
                        continue;
                    }

                }
                Rectangles.Add(new Rectangle(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), i));
            }
            Rectangles.OrderBy(a => rnd.Next()).ToList();


        }





    }
}
