using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_TriV2._View
{
    public class DisplaySorting : PictureBox
    {
        private const int MAXRECTANGLE = 20;

        private Random rnd = new Random();

        public List<myRectangle> Rectangles;

        public DisplaySorting()
        {
            //Initialize Rectangle list
            Rectangles = new List<myRectangle>();
            //Initialize all the random rectangle
            for (int i = 1; i <= MAXRECTANGLE; i++)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                // Check if color already exist in our list of rectangle
                foreach (myRectangle rectangle in Rectangles)
                {

                    if (rectangle.CurrentColor == randomColor)
                    {
                        i -= 1;
                        continue;
                    }

                }
                Rectangles.Add(new myRectangle(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), i));
            }
            // Randomize the list of Rectangle
            RandomizeRectangleList();

            // Draw all rectangle
            Paint += DrawMyRectangle;

        }


        public void DrawMyRectangle(object sender, PaintEventArgs e)
        {

            int xPos = 0;
            foreach (myRectangle rectangle in Rectangles)
            {
                using (Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
                {
                    // Create rectangle.
                    Rectangle rect = new Rectangle(xPos, 0, 30, rectangle.CurrentSize * 20);

                    // Create a StringFormat object with the each line of text, and the block
                    // of text centered on the page.
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    // Draw rectangle to screen.
                    e.Graphics.FillRectangle(new SolidBrush(rectangle.CurrentColor), rect);

                    e.Graphics.DrawString(Convert.ToString(rectangle.CurrentSize), font, Brushes.White, rect, stringFormat);
                    xPos += 40;
                }
            }

        }

        public void RandomizeRectangleList()
        {
            Rectangles = Rectangles.OrderBy(a => rnd.Next()).ToList();
        }

    }
}
