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

        public List<myRectangle > Rectangles { get; set; }

        public List<string> PseudoCode { get; set; }

        public List<string> GetPseudoCode()
        {
            switch (SortingMethod)
            {
                case "BulleSort": List<string> bulleSortCode = new List<string>();
                    bulleSortCode.Add("PROCEDURE tri_bulle ( TABLEAU a[1:n])");
                    bulleSortCode.Add("passage ← 0");
                    bulleSortCode.Add("REPETER");
                    bulleSortCode.Add("    permut ← FAUX");
                    bulleSortCode.Add("    POUR i VARIANT DE 1 A n - 1 - passage FAIRE");
                    bulleSortCode.Add("        SI a[i] > a[i+1] ALORS");
                    bulleSortCode.Add("            echanger a[i] ET a[i+1]");
                    bulleSortCode.Add("            permut ← VRAI");
                    bulleSortCode.Add("        FIN SI");
                    bulleSortCode.Add("    FIN POUR");
                    bulleSortCode.Add("    passage ← passage + 1");
                    bulleSortCode.Add("TANT QUE permut = VRAI");
                    return bulleSortCode;
                case "SelectionSort": List<string> selectionSortCode = new List<string>();
                    selectionSortCode.Add("PROCEDURE tri_Selection ( Tableau a[1:n])");
                    selectionSortCode.Add("    POUR i VARIANT DE 1 A n - 1 FAIRE");
                    selectionSortCode.Add("        TROUVER [j] LE PLUS PETIT ELEMENT DE [i + 1:n];");
                    selectionSortCode.Add("        ECHANGER [j] ET [i];");
                    selectionSortCode.Add("FIN PROCEDURE;");
                    return selectionSortCode;
                case "PeigneSort": List<string> peigneSortCode = new List<string>();
                    peigneSortCode.Add("PROCEDURE tri_peigne ( TABLEAU a[1:n])");
                    peigneSortCode.Add("gap ← n");
                    peigneSortCode.Add("REPETER");
                    peigneSortCode.Add("    permut ← FAUX");
                    peigneSortCode.Add("    gap ← gap / 1.3");
                    peigneSortCode.Add("    SI gap < 1 ALORS gap ← 1");
                    peigneSortCode.Add("    POUR i VARIANT DE 1 A n AVEC UN PAS gap FAIRE");
                    peigneSortCode.Add("        SI a[i] > a[i+gap] ALORS");
                    peigneSortCode.Add("            echanger a[i] et a[i+gap]");
                    peigneSortCode.Add("            permut ← VRAI");
                    peigneSortCode.Add("        FIN SI");
                    peigneSortCode.Add("    FIN POUR");
                    peigneSortCode.Add("TANT QUE permut = VRAI OU gap > 1");
                    return peigneSortCode;
                case "ShellSort": List<string> shellSortCode = new List<string>();
                    shellSortCode.Add("PROCEDURE tri_Insertion ( Tableau a[1:n],gap,debut)");
                    shellSortCode.Add("    POUR i VARIANT DE debut A n AVEC UN PAS gap FAIRE");
                    shellSortCode.Add("        INSERER a[i] à sa place dans a[1:i-1];");
                    shellSortCode.Add("FIN PROCEDURE;");
                    shellSortCode.Add(" ");
                    shellSortCode.Add("PROCEDURE tri_shell ( Tableau a[1:n])");
                    shellSortCode.Add("    POUR gap DANS (6,4,3,2,1) FAIRE");
                    shellSortCode.Add("       POUR debut VARIANT DE 0 A gap - 1 FAIRE");
                    shellSortCode.Add("          tri_Insertion(Tableau,gap,debut);");
                    shellSortCode.Add("       FIN POUR;");
                    shellSortCode.Add("    FIN POUR;");
                    shellSortCode.Add("FIN PROCEDURE;");
                    return shellSortCode;
                case "InsertionSort": List<string> insertionSortCode = new List<string>();
                    insertionSortCode.Add("PROCEDURE tri_Insertion ( Tableau a[1:n])");
                    insertionSortCode.Add("    POUR i VARIANT DE 2 A n FAIRE");
                    insertionSortCode.Add("        INSERER a[i] à sa place dans a[1:i-1];");
                    insertionSortCode.Add("FIN PROCEDURE;");
                    return insertionSortCode;
                default: return new List<string>();
            }
        }

        public List<myRectangle> SortRectangle()
        {
            switch (SortingMethod)
            {
                case "BulleSort":

                    return BulleSortMethod();
                case "SelectionSort":

                    return SelectionSortMethod();
                case "PeigneSort":

                    return PeigneSortMethod();
                case "ShellSort":

                    return ShellSortMethod();
                case "InsertionSort":

                    return InsertionSortMethod();
                default: return new List<myRectangle>();
            }
        }

        public List<myRectangle> BulleSortMethod()
        {

            return new List<myRectangle>();
        }

        public List<myRectangle> SelectionSortMethod()
        {

            return new List<myRectangle>();
        }
        public List<myRectangle> PeigneSortMethod()
        {

            return new List<myRectangle>();
        }
        public List<myRectangle> ShellSortMethod()
        {

            return new List<myRectangle>();
        }
        public List<myRectangle> InsertionSortMethod()
        {

            return new List<myRectangle>();
        }



    }
}
