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

        public int SpeedSort { get; set; }

        public List<myRectangle> Rectangles { get; set; }

        public string PseudoCode { get; set; }

        public DisplaySorting sortRectangle()
        {
            DisplaySorting displaySorting = new DisplaySorting();
            return displaySorting;
        }

    }
}
