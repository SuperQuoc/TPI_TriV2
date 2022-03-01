using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_TriV2._View;

namespace TPI_TriV2._Model
{
    public class Model
    {

        public string SortingMethod { get; set; }

        public List<_View.Rectangle> Rectangles { get; set; }

        public DisplaySorting sortRectangle()
        {
            return new DisplaySorting();
        }

    }
}
