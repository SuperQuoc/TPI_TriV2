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

        public string PseudoCode
        {
            get { return lbxPseudoCode.Text; }
            set { lbxPseudoCode.Text = value;}
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

        public DisplaySorting Output
        {
            get { return displaySorting; }
            set { displaySorting = value; }
        }

        public FrmMain()
        {
            InitializeComponent();
            currentMethod = "BulleSort";
            cbxSpeed.SelectedIndex = 3;
        }

        private void miBulle_Click(object sender, EventArgs e)
        {
            currentMethod = "BulleSort";
        }

        private void miSelection_Click(object sender, EventArgs e)
        {
            currentMethod = "SelectionSort";
        }

        private void miPeigne_Click(object sender, EventArgs e)
        {
            currentMethod = "PeigneSort";
        }

        private void miShell_Click(object sender, EventArgs e)
        {
            currentMethod = "ShellSort";
        }

        private void miInsertion_Click(object sender, EventArgs e)
        {
            currentMethod = "InsertionSort";
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

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller(this);
            controller.SortInput();

        }
    }
}
