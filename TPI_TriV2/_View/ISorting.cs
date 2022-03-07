using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_TriV2._View
{
    public interface ISorting
    {
        String PseudoCode { get; set;  }
        int SpeedSort { get; }
        String SortingMethod { get; set; }
        List<myRectangle> Rectangles { get; set; }

    }
}
