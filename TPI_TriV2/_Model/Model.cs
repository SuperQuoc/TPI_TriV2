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
            List<myRectangle> rectangleToSort = Rectangles;
            bool permutation = true;
            int passage = 0;
            
            while(permutation == true)
            {
                permutation = false;
                passage++;
                for (int i = 0; i < rectangleToSort.Count()-passage; i++)
                {
                    if (rectangleToSort[i].CurrentSize > rectangleToSort[i+1].CurrentSize)
                    {
                        permutation = true;

                        myRectangle temp = rectangleToSort[i];
                        rectangleToSort[i] = rectangleToSort[i+1];
                        rectangleToSort[i + 1] = temp;
                    }
                }
            }


            return rectangleToSort;
        }

        public List<myRectangle> SelectionSortMethod()
        {

            List<myRectangle> rectangleToSort = Rectangles;

            int n = rectangleToSort.Count;

            for (int i = 0; i < n-1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (rectangleToSort[j].CurrentSize < rectangleToSort[min_idx].CurrentSize)
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                myRectangle temp = rectangleToSort[min_idx];
                rectangleToSort[min_idx] = rectangleToSort[i];
                rectangleToSort[i] = temp;
            }


            return rectangleToSort;
        }
        public List<myRectangle> PeigneSortMethod()
        {
            List<myRectangle> rectangleToSort = Rectangles;
            int n = rectangleToSort.Count;

            // initialize gap
            int gap = n;

            // Initialize swapped as true to
            // make sure that loop runs
            bool swapped = true;

            // Keep running while gap is more than
            // 1 and last iteration caused a swap
            while (gap != 1 || swapped == true)
            {
                // Find next gap
                gap = getNextGap(gap);

                // Initialize swapped as false so that we can
                // check if swap happened or not
                swapped = false;

                // Compare all elements with current gap
                for (int i = 0; i < n - gap; i++)
                {
                    if (rectangleToSort[i].CurrentSize > rectangleToSort[i + gap].CurrentSize)
                    {
                        // Swap arr[i] and arr[i+gap]
                        myRectangle temp = rectangleToSort[i];
                        rectangleToSort[i] = rectangleToSort[i + gap];
                        rectangleToSort[i + gap] = temp;

                        // Set swapped
                        swapped = true;
                    }
                }
            }
            return rectangleToSort;
        }
        public List<myRectangle> ShellSortMethod()
        {
            List<myRectangle> rectangleToSort = Rectangles;


            int n = rectangleToSort.Count;

            // Start with a big gap,
            // then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already
                // in gapped order keep adding one more element
                // until the entire array is gap sorted
                for (int i = gap; i < n; i += 1)
                {
                    // add a[i] to the elements that have
                    // been gap sorted save a[i] in temp and
                    // make a hole at position i
                    myRectangle temp = rectangleToSort[i];

                    // shift earlier gap-sorted elements up until
                    // the correct location for a[i] is found
                    int j;
                    for (j = i; j >= gap && rectangleToSort[j - gap].CurrentSize > temp.CurrentSize; j -= gap)
                        rectangleToSort[j] = rectangleToSort[j - gap];

                    // put temp (the original a[i])
                    // in its correct location
                    rectangleToSort[j] = temp;
                }
            }

            return rectangleToSort;
        }
        public List<myRectangle> InsertionSortMethod()
        {
            List<myRectangle> rectangleToSort = Rectangles;

            int n = rectangleToSort.Count;
            for (int i = 1; i < n; ++i)
            {
                myRectangle key = rectangleToSort[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && rectangleToSort[j].CurrentSize > key.CurrentSize)
                {
                    rectangleToSort[j + 1] = rectangleToSort[j];
                    j = j - 1;
                }
                rectangleToSort[j + 1] = key;
            }

            return rectangleToSort;
        }

        static int getNextGap(int gap)
        {
            // Shrink gap by Shrink factor
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }



    }
}
