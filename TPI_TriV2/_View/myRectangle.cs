using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_TriV2._View
{
    public class myRectangle
    {
        private Color _currentColor;
        private int _currentSize;

        public myRectangle(Color currentColor, int currentSize)
        {
            CurrentColor = currentColor;
            CurrentSize = currentSize;
        }

        public Color CurrentColor { get => _currentColor; set => _currentColor = value; }
        public int CurrentSize { get => _currentSize; set => _currentSize = value; }

    }
}
