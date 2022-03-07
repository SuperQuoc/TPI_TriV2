using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_TriV2._Controller;
using TPI_TriV2._View;


namespace TPI_TriV2
{
    public partial class FrmMain : Form, ISorting
    {
        private string currentMethod;

        Controller controller;

        public List<string> PseudoCode
        {
            get {
                List<string> myListPseudoCode = new List<string>();
                foreach (string s in lbxPseudoCode.Items)
                {
                    myListPseudoCode.Add(s);
                }
                return myListPseudoCode; }
            set { 
                lbxPseudoCode.Items.Clear();
                foreach(string s in value)
                {
                    lbxPseudoCode.Items.Add(s);
                }
                }
        }
        public int SpeedSort
        {
            get
            {
                switch (cbxSpeed.Text)
                {
                    case "Pas à pas": return 1;
                    case "Très lent": return 2;
                    case "Lent": return 3;
                    case "Normal": return 4;
                    case "Rapide": return 5;
                    default: return 0;
                }
            }

        }
        public string SortingMethod
        {
            get { return currentMethod; }
            set { currentMethod = value; }
        }

        public List<myRectangle> Rectangles
        {
            get { return displaySorting.Rectangles; }
            set { displaySorting.Rectangles = value; }
        }

        public FrmMain()
        {
            //Initialize and default value
            InitializeComponent();
            currentMethod = "BulleSort";
            cbxSpeed.SelectedIndex = 3;
            controller = new Controller(this);

        }

        private void miBulle_Click(object sender, EventArgs e)
        {
            currentMethod = "BulleSort";

            controller.UpdatePseudoCode();
        }

        private void miSelection_Click(object sender, EventArgs e)
        {
            currentMethod = "SelectionSort";

            controller.UpdatePseudoCode();
        }

        private void miPeigne_Click(object sender, EventArgs e)
        {
            currentMethod = "PeigneSort";

            controller.UpdatePseudoCode();
        }

        private void miShell_Click(object sender, EventArgs e)
        {
            currentMethod = "ShellSort";

            controller.UpdatePseudoCode();
        }

        private void miInsertion_Click(object sender, EventArgs e)
        {
            currentMethod = "InsertionSort";

            controller.UpdatePseudoCode();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            About aboutbox = new About();
            aboutbox.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            controller.UpdatePseudoCode();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            
            controller.SortInput();

            updateDisplaySorting();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {

            displaySorting.RandomizeRectangleList();
            updateDisplaySorting();

        }

        public void updateDisplaySorting()
        {
            //displaySorting.Paint += displaySorting.DrawMyRectangle;
            displaySorting.Invalidate();
        }

    }
}
