using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Tetris.Class_Folder;
using System.Windows.Forms;
using System.Media;


namespace Tetris.Form_Folder
{
    public partial class Tetris_MainForm : Form
    {
        bool goLeft, goRight;
        Label[,] labelField = new Label[10,15];
        Cell[,] cellField = new Cell[10,15];
        
        GameGrid grid = new GameGrid();
        Block[] gameBlock = new Block[7];
        BlockQueue blockList = new BlockQueue();
        Color color = Color.Blue;
        public Block[] stonePositionArr;
        Positon[,] startArr = new Positon[,]{
        {new Positon(0,3),new Positon(0,4), new Positon(0,5),new Positon(0,6)},
        {new Positon(1,3),new Positon(1,4), new Positon(1,5),new Positon(1,6)},
        {new Positon(2,3),new Positon(2,4), new Positon(2,5),new Positon(2,6)},
        {new Positon(3,3),new Positon(3,4), new Positon(3,5),new Positon(3,6)}
        };
        public Tetris_MainForm(){
            InitializeComponent();
            Settings.Width = main_panel1.Width / 10;
            Settings.Height = main_panel1.Height / 15;
        }

        private void Tetris_MainForm_Load(object sender, EventArgs e){
            Settings.gameIndex = 0;
            printGrid();
            loadCell();
            grid.ActiveCell.rotateGameObject(startArr, blockList, Settings.rotateCount, grid);
        }
        void loadCell(){ 
            for (int i = 0; i < 10; i++){
                for (int j = 0; j < 15; j++){
                    checkObjectColor(i,j);
                }
            }
        }
        void checkObjectColor(int i,int j){
            if (grid.ActiveCell[i, j] != 0){
                if (grid.ActiveCell[i, j] == 1){
                    labelField[i, j].BackColor = Color.LightSkyBlue;
                }
                if (grid.ActiveCell[i, j] == 2){
                    labelField[i, j].BackColor = Color.Blue;
                }
                if (grid.ActiveCell[i, j] == 3){
                    labelField[i, j].BackColor = Color.Orange;
                }
                if (grid.ActiveCell[i, j] == 4){
                    labelField[i, j].BackColor = Color.Yellow;
                }
                if (grid.ActiveCell[i, j] == 5){
                    labelField[i, j].BackColor = Color.Green;
                }
                if (grid.ActiveCell[i, j] == 6){
                    labelField[i, j].BackColor = Color.Purple;
                }
                if (grid.ActiveCell[i, j] == 7){
                    labelField[i, j].BackColor = Color.Red;
                }
            }
            else{
                labelField[i, j].BackColor = Color.Black;
            }
        }
        void printGrid(){
            for (int i = 0; i < 10; i++){
                for (int j = 0; j < 15; j++){
                    labelField[i, j] = new Label();
                    labelField[i, j].BorderStyle = BorderStyle.FixedSingle;
                    labelField[i, j].Width = Settings.Width;
                    labelField[i, j].Height = Settings.Height;
                    labelField[i, j].Location = new Point(Settings.Width * i,
                    Settings.Height* j);
                    labelField[i, j].Tag = new Point(i, j);
                    main_panel1.Controls.Add(labelField[i, j]);
                }
            }
        }
        private void Tetris_MainForm_KeyUp(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Left){
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right){
                goRight = false;
            }
        }
        private void Tetris_MainForm_KeyDown(object sender, KeyEventArgs e){
            if(e.KeyCode == Keys.Left && !goRight){
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right && !goLeft){
                goRight = true;
            }
            if(e.KeyCode == Keys.Up){
                Settings.rotateCount++;
                if (Settings.rotateCount == 4){
                    Settings.rotateCount = 0;
                }
                grid.ActiveCell.rotateGameObject(startArr, blockList, Settings.rotateCount, grid);
            }
            if(e.KeyCode == Keys.Down){
            }
        }

        private void main_panel1_Paint(object sender, PaintEventArgs e){
        }

        private void tetris_animation_timer1_Tick(object sender, EventArgs e){
           if (color != Color.Blue)
           color = Color.Blue;
           else
           color = Color.Red;

            header_label1.ForeColor= color;
        }

        private void start_label3_Click(object sender, EventArgs e){
            Settings.rotateCount = 0;
            Settings.gameIndex = 0;
            Settings.moveIncrement = 0;
            Settings.fallIncrement = 0;
            Settings.rotatelocked = false;
            resetGrid();
            loadCell();
            grid.ActiveCell.rotateGameObject(startArr, blockList, Settings.rotateCount, grid);
            game_timer1.Enabled = true;

        }
        void resetGrid(){
            for(int i = 0; i < 10; i++){
                for (int j = 0; j < 15; j++)
                {
                    grid.ActiveCell[i, j] = 0;
                }
            }
        }

        private void exit_label3_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void game_timer1_Tick(object sender, EventArgs e){
                if (Settings.gameOver){
                Settings.gameOver = false;
                start_label3_Click(sender, e);
                }
                if (Settings.newGameObject){
                    grid.ActiveCell.rotateGameObject(startArr, blockList, Settings.rotateCount, grid);
                    Settings.newGameObject = false;
                }
                if (!grid.ActiveCell.moveCell(grid, goLeft, goRight)){
                    Settings.fallIncrement++;
                    grid.ActiveCell.fallCell(grid);
                }
                loadCell();
                grid.ActiveCell.makeRotateBlocking(grid);

        }
    }
}
