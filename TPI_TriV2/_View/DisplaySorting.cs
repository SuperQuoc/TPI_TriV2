using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_TriV2._View
{
    public class DisplaySorting : PictureBox
    {
        private List<_View.Rectangle> _rectangles;

        public List<Rectangle> Rectangles { get => _rectangles; set => _rectangles = value; }

        public DisplaySorting()
        {
        }
    }
}
