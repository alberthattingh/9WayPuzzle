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
        public int value;

        public int currentX;
        public int currentY;

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

                int tempVal = value;
                value = other.value;
                other.value = tempVal;

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

            int tempVal = value;
            value = emptyTile.value;
            emptyTile.value = tempVal;

            return this;
        }

        internal void SetNewImage(int newVal)
        {
            Image newImage = null;

            switch (newVal)
            {
                case 0:
                    newImage = null;
                    BackColor = Color.FromArgb(0, 176, 115);
                    break;
                case 1:
                    newImage = Properties.Resources.icons8_1_100;
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case 2:
                    newImage = Properties.Resources.icons8_2_100;
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case 3:
                    newImage = Properties.Resources.icons8_3_100;
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case 4:
                    newImage = Properties.Resources.icons8_4_100;
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case 5:
                    newImage = Properties.Resources.icons8_5_100;
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case 6:
                    newImage = Properties.Resources.icons8_6_100;
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case 7:
                    newImage = Properties.Resources.icons8_7_100;
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case 8:
                    newImage = Properties.Resources.icons8_8_100;
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
            }

            BackgroundImage = newImage;
        }
    }
}
