using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9WayPuzzle
{
    public partial class Form1 : Form
    {
        private Tile emptyTile;
        private int movesCount;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movesCount = 0;

            tile1.correctX = 0;
            tile1.currentX = 0;
            tile1.correctY = 0;
            tile1.currentY = 0;

            tile2.correctX = 1;
            tile2.currentX = 1;
            tile2.correctY = 0;
            tile2.currentY = 0;

            tile3.correctX = 2;
            tile3.currentX = 2;
            tile3.correctY = 0;
            tile3.currentY = 0;

            tile4.correctX = 0;
            tile4.currentX = 0;
            tile4.correctY = 1;
            tile4.currentY = 1;

            tile5.correctX = 1;
            tile5.currentX = 1;
            tile5.correctY = 1;
            tile5.currentY = 1;

            tile6.correctX = 2;
            tile6.currentX = 2;
            tile6.correctY = 1;
            tile6.currentY = 1;

            tile7.correctX = 0;
            tile7.currentX = 0;
            tile7.correctY = 2;
            tile7.currentY = 2;

            tile8.correctX = 1;
            tile8.currentX = 1;
            tile8.correctY = 2;
            tile8.currentY = 2;

            tile9.correctX = 2;
            tile9.currentX = 2;
            tile9.correctY = 2;
            tile9.currentY = 2;

            emptyTile = tile9;

            //shuffleTiles();
        }

        private Tile getTileAtPosition(int[] position)
        {
            Tile tile = null;
            foreach (Control control in tilesContainer.Controls)
            {
                tile = (Tile)control;
                if (tile.currentX == position[0] && tile.currentY == position[1])
                {
                    return tile;
                }
            }
            return tile;
        }

        private void shuffleTiles()
        {
            do
            {
                List<int[]> indexes = new List<int[]>( new int[][] { new int[] {0,0}, new int[] {0,1}, new int[] {0,2},
                                                                     new int[] {1,0}, new int[] {1,1}, new int[] {1,2},
                                                                     new int[] {2,0}, new int[] {2,1}, new int[] {2,2} });

                Random random = new Random();
                int[] position;
                int j;
                Tile tileToSwap;

                for (int i = 0; i < 9; i++)
                {
                    j = random.Next(0, indexes.Count);
                    position = indexes[j];
                    indexes.RemoveAt(j);

                    tileToSwap = (Tile)tilesContainer.Controls[i];
                    if (i == 8)
                    {
                        emptyTile = tileToSwap.swapTiles(getTileAtPosition(position), true);
                    }
                    else
                    {
                        tileToSwap.swapTiles(getTileAtPosition(position), false);
                    }
                }
            }
            while (checkWin()); // to make sure when shuffled it doesn't shuffle to solution
         
        }

        private void clickOnTile(object sender, EventArgs e)
        {
            Tile tile = sender as Tile;
            
            if (tile.isNextTo(emptyTile))
            {
                emptyTile = tile.swapTiles(emptyTile, true);
                movesCount++;
                lblMoves.Text = movesCount.ToString();

                if (checkWin())
                {
                    MessageBox.Show("Congratulations! You win! You finished in " + movesCount + " moves.", "Congratulations!");
                    Application.Exit();
                }
            }
        }

        private bool checkWin()
        {
            if (tile1.currentX != tile1.correctX || tile1.currentY != tile1.correctY)
                return false;

            if (tile2.currentX != tile2.correctX || tile2.currentY != tile2.correctY)
                return false;

            if (tile3.currentX != tile3.correctX || tile3.currentY != tile3.correctY)
                return false;

            if (tile4.currentX != tile4.correctX || tile4.currentY != tile4.correctY)
                return false;

            if (tile5.currentX != tile5.correctX || tile5.currentY != tile5.correctY)
                return false;

            if (tile6.currentX != tile6.correctX || tile6.currentY != tile6.correctY)
                return false;

            if (tile7.currentX != tile7.correctX || tile7.currentY != tile7.correctY)
                return false;

            if (tile8.currentX != tile8.correctX || tile8.currentY != tile8.correctY)
                return false;

            if (tile9.currentX != tile9.correctX || tile9.currentY != tile9.correctY)
                return false;

            return true;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            shuffleTiles();
        }
    }
}
