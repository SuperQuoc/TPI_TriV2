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

        private Model model;


        public Controller(ISorting view)
        {
            sortView = view;
            model = new Model();
        }

        public void SortInput()
        {

            model.SpeedSort = sortView.SpeedSort;
            model.SortingMethod = sortView.SortingMethod;
            model.PseudoCode = sortView.PseudoCode;
            model.Rectangles = sortView.Rectangles;

            sortView.Rectangles = model.SortRectangle();

        }

        public void UpdatePseudoCode()
        {
            model.SortingMethod = sortView.SortingMethod;
            sortView.PseudoCode = model.GetPseudoCode();
        }

    }
}
