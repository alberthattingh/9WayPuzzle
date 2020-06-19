using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _9WayPuzzle
{
    public class Tile : PictureBox
    {
        public int currentX;
        public int currentY;
        public int correctX;
        public int correctY;

        public bool isEmpty;

        public bool isNextTo(Tile other)
        {
            if (currentY == other.currentY)
            {
                if (currentX == other.currentX + 1 || currentX == other.currentX - 1)
                {
                    return true;
                }
            }
            else if (currentX == other.currentX)
            {
                if (currentY == other.currentY + 1 || currentY == other.currentY - 1)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

            return false;
        }

        public Tile swapTiles(Tile other, bool empty)
        {
            if (empty)
            {
                return swapWithEmptyTile(other);
            }
            else
            {
                Color tempColor = BackColor;
                BackColor = other.BackColor;
                other.BackColor = tempColor;

                object tempImage = BackgroundImage;
                BackgroundImage = other.BackgroundImage;
                other.BackgroundImage = (Image)tempImage;

                int tempCorrectX, tempCorrectY, tempCurrentX, tempCurrentY;
                tempCorrectX = correctX;
                tempCorrectY = correctY;
                // tempCurrentX = currentX;
                // tempCurrentY = currentY;

                correctX = other.correctX;
                correctY = other.correctY;
                // currentX = other.currentX;
                // currentY = other.currentY;

                other.correctX = tempCorrectX;
                other.correctY = tempCorrectY;
                // other.currentX = tempCurrentX;
                // other.currentY = tempCurrentY;

                return this;
            }            
        }

        private Tile swapWithEmptyTile(Tile emptyTile)
        {
            Color tempColor = BackColor;
            BackColor = emptyTile.BackColor;
            emptyTile.BackColor = tempColor;

            emptyTile.BackgroundImage = BackgroundImage;
            BackgroundImage = null;

            isEmpty = true;
            emptyTile.isEmpty = false;

            int tempCorrectX, tempCorrectY, tempCurrentX, tempCurrentY;
            tempCorrectX = correctX;
            tempCorrectY = correctY;
            // tempCurrentX = currentX;
            // tempCurrentY = currentY;

            correctX = emptyTile.correctX;
            correctY = emptyTile.correctY;
            // currentX = other.currentX;
            // currentY = other.currentY;

            emptyTile.correctX = tempCorrectX;
            emptyTile.correctY = tempCorrectY;
            // other.currentX = tempCurrentX;
            // other.currentY = tempCurrentY;

            return this;
        }
    }
}
