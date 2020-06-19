using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9WayPuzzle
{
    public partial class Form1 : Form
    {
        private Tile[] tiles;
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
            SetInitialTileValues();         
            emptyTile = tile9;

            //shuffleTiles();
        }

        private void SetInitialTileValues()
        {
            tiles = new Tile[] { tile1, tile2, tile3,
                                 tile4, tile5, tile6,
                                 tile7, tile8, tile9
                                };

            tile1.currentX = 0;
            tile1.currentY = 0;
            tile1.value = 1;
            
            tile2.currentX = 1;
            tile2.currentY = 0;
            tile2.value = 2;
            
            tile3.currentX = 2;
            tile3.currentY = 0;
            tile3.value = 3;
            
            tile4.currentX = 0;
            tile4.currentY = 1;
            tile4.value = 4;
            
            tile5.currentX = 1;
            tile5.currentY = 1;
            tile5.value = 5;
            
            tile6.currentX = 2;
            tile6.currentY = 1;
            tile6.value = 6;
            
            tile7.currentX = 0;
            tile7.currentY = 2;
            tile7.value = 7;
            
            tile8.currentX = 1;
            tile8.currentY = 2;
            tile8.value = 8;
            
            tile9.currentX = 2;
            tile9.currentY = 2;
            tile9.value = 0;
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
                List<int> indexes = new List<int>( new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8});

                Random random = new Random();
                int newVal;
                int j;

                foreach (Tile t in tiles)
                {
                    j = random.Next(0, indexes.Count);
                    newVal = indexes[j];
                    indexes.RemoveAt(j);

                    t.value = newVal;
                    t.SetNewImage(newVal);

                    if (newVal == 0)
                        emptyTile = t;
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
            if (tile1.value != 1)
                return false;

            if (tile2.value != 2)
                return false;

            if (tile3.value != 3)
                return false;

            if (tile4.value != 4)
                return false;

            if (tile5.value != 5)
                return false;

            if (tile6.value != 6)
                return false;

            if (tile7.value != 7)
                return false;

            if (tile8.value != 8)
                return false;

            if (tile9.value != 0)
                return false;

            return true;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            shuffleTiles();
        }

        private void btnGetBoard_Click(object sender, EventArgs e)
        {
            string[] row;
            List<string> boardValues = new List<string>();

            openFileDialog1.Title = "Select a CSV file";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "CSV Files|*.csv";

            Stream myStream = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            var reader = new StreamReader(myStream);
                            while (!reader.EndOfStream)
                            {

                                string line = reader.ReadLine();
                                row = line.Split(',');
                                boardValues.AddRange(row);
                            }
                        }
                    }
                    if (boardValues.Count == 9)
                    {
                        int newVal;
                        for (int i = 0; i < 9; i++)
                        {
                            newVal = Int32.Parse(boardValues[i]);
                            tiles[i].value = newVal;
                            tiles[i].SetNewImage(newVal);

                            if (newVal == 0)
                                emptyTile = tiles[i];
                        }
                    }
                    // MessageBox.Show("The board was successfully updated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Could not open file: " + ex.Message);
                }
            }
        }
    }
}
