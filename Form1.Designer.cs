namespace _9WayPuzzle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tilesContainer = new System.Windows.Forms.Panel();
            this.tile6 = new _9WayPuzzle.Tile();
            this.tile3 = new _9WayPuzzle.Tile();
            this.tile9 = new _9WayPuzzle.Tile();
            this.tile8 = new _9WayPuzzle.Tile();
            this.tile7 = new _9WayPuzzle.Tile();
            this.tile5 = new _9WayPuzzle.Tile();
            this.tile4 = new _9WayPuzzle.Tile();
            this.tile2 = new _9WayPuzzle.Tile();
            this.tile1 = new _9WayPuzzle.Tile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMoves = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetBoard = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tilesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tile6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tilesContainer
            // 
            this.tilesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.tilesContainer.Controls.Add(this.tile6);
            this.tilesContainer.Controls.Add(this.tile3);
            this.tilesContainer.Controls.Add(this.tile9);
            this.tilesContainer.Controls.Add(this.tile8);
            this.tilesContainer.Controls.Add(this.tile7);
            this.tilesContainer.Controls.Add(this.tile5);
            this.tilesContainer.Controls.Add(this.tile4);
            this.tilesContainer.Controls.Add(this.tile2);
            this.tilesContainer.Controls.Add(this.tile1);
            this.tilesContainer.Location = new System.Drawing.Point(12, 68);
            this.tilesContainer.Name = "tilesContainer";
            this.tilesContainer.Size = new System.Drawing.Size(590, 590);
            this.tilesContainer.TabIndex = 0;
            // 
            // tile6
            // 
            this.tile6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tile6.BackgroundImage = global::_9WayPuzzle.Properties.Resources.icons8_6_100;
            this.tile6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile6.Location = new System.Drawing.Point(395, 199);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(190, 190);
            this.tile6.TabIndex = 0;
            this.tile6.TabStop = false;
            this.tile6.Click += new System.EventHandler(this.clickOnTile);
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tile3.BackgroundImage = global::_9WayPuzzle.Properties.Resources.icons8_3_100;
            this.tile3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile3.Location = new System.Drawing.Point(395, 3);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(190, 190);
            this.tile3.TabIndex = 0;
            this.tile3.TabStop = false;
            this.tile3.Click += new System.EventHandler(this.clickOnTile);
            // 
            // tile9
            // 
            this.tile9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.tile9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile9.Location = new System.Drawing.Point(395, 395);
            this.tile9.Name = "tile9";
            this.tile9.Size = new System.Drawing.Size(190, 190);
            this.tile9.TabIndex = 0;
            this.tile9.TabStop = false;
            this.tile9.Click += new System.EventHandler(this.clickOnTile);
            // 
            // tile8
            // 
            this.tile8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tile8.BackgroundImage = global::_9WayPuzzle.Properties.Resources.icons8_8_100;
            this.tile8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile8.Location = new System.Drawing.Point(199, 395);
            this.tile8.Name = "tile8";
            this.tile8.Size = new System.Drawing.Size(190, 190);
            this.tile8.TabIndex = 0;
            this.tile8.TabStop = false;
            this.tile8.Click += new System.EventHandler(this.clickOnTile);
            // 
            // tile7
            // 
            this.tile7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tile7.BackgroundImage = global::_9WayPuzzle.Properties.Resources.icons8_7_100;
            this.tile7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile7.Location = new System.Drawing.Point(3, 395);
            this.tile7.Name = "tile7";
            this.tile7.Size = new System.Drawing.Size(190, 190);
            this.tile7.TabIndex = 0;
            this.tile7.TabStop = false;
            this.tile7.Click += new System.EventHandler(this.clickOnTile);
            // 
            // tile5
            // 
            this.tile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tile5.BackgroundImage = global::_9WayPuzzle.Properties.Resources.icons8_5_100;
            this.tile5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile5.Location = new System.Drawing.Point(199, 199);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(190, 190);
            this.tile5.TabIndex = 0;
            this.tile5.TabStop = false;
            this.tile5.Click += new System.EventHandler(this.clickOnTile);
            // 
            // tile4
            // 
            this.tile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tile4.BackgroundImage = global::_9WayPuzzle.Properties.Resources.icons8_4_100;
            this.tile4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile4.Location = new System.Drawing.Point(3, 199);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(190, 190);
            this.tile4.TabIndex = 0;
            this.tile4.TabStop = false;
            this.tile4.Click += new System.EventHandler(this.clickOnTile);
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tile2.BackgroundImage = global::_9WayPuzzle.Properties.Resources.icons8_2_100;
            this.tile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile2.Location = new System.Drawing.Point(199, 3);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(190, 190);
            this.tile2.TabIndex = 0;
            this.tile2.TabStop = false;
            this.tile2.Click += new System.EventHandler(this.clickOnTile);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tile1.BackgroundImage = global::_9WayPuzzle.Properties.Resources.icons8_1_100;
            this.tile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tile1.Location = new System.Drawing.Point(3, 3);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(190, 190);
            this.tile1.TabIndex = 0;
            this.tile1.TabStop = false;
            this.tile1.Click += new System.EventHandler(this.clickOnTile);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 48);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::_9WayPuzzle.Properties.Resources.icons8_close_window_50;
            this.btnExit.Location = new System.Drawing.Point(1035, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.btnShuffle.Location = new System.Drawing.Point(689, 614);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(318, 44);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "SHUFFLE";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.panel3.Location = new System.Drawing.Point(689, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 190);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 182);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblMoves);
            this.panel5.Location = new System.Drawing.Point(3, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 69);
            this.panel5.TabIndex = 5;
            // 
            // lblMoves
            // 
            this.lblMoves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.Location = new System.Drawing.Point(0, 0);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(304, 69);
            this.lblMoves.TabIndex = 1;
            this.lblMoves.Text = "0";
            this.lblMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 64);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMBER OF MOVES:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_9WayPuzzle.Properties.Resources.original;
            this.pictureBox1.Location = new System.Drawing.Point(752, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnGetBoard
            // 
            this.btnGetBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.btnGetBoard.Location = new System.Drawing.Point(689, 553);
            this.btnGetBoard.Name = "btnGetBoard";
            this.btnGetBoard.Size = new System.Drawing.Size(318, 44);
            this.btnGetBoard.TabIndex = 2;
            this.btnGetBoard.Text = "GET BOARD FROM FILE";
            this.btnGetBoard.UseVisualStyleBackColor = true;
            this.btnGetBoard.Click += new System.EventHandler(this.btnGetBoard_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGetBoard);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tilesContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tilesContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tile6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tilesContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Tile tile6;
        private Tile tile3;
        private Tile tile9;
        private Tile tile8;
        private Tile tile7;
        private Tile tile5;
        private Tile tile4;
        private Tile tile2;
        private Tile tile1;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetBoard;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

