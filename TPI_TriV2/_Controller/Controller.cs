using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI_TriV2._Model;
using TPI_TriV2._View;
using System.Windows.Forms;

namespace TPI_TriV2._Controller
{
    public class Controller
    {
        private readonly ISorting sortView;


        public Controller(ISorting view)
        {
            sortView = view;
        }

        public void SortInput()
        {
            Model model = new Model();
            model.SpeedSort = sortView.SpeedSort;
            model.SortingMethod = sortView.SortingMethod;
            model.PseudoCode = sortView.PseudoCode;
            model.Rectangles = sortView.Rectangles;



        }

    }
}
