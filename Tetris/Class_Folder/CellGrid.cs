using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tetris.Class_Folder
{
    public class Cell {
        private readonly int[,] grid = new int[10, 15];
        Positon[,] startArr = new Positon[,]{
        {new Positon(0,3),new Positon(0,4), new Positon(0,5),new Positon(0,6)},
        {new Positon(1,3),new Positon(1,4), new Positon(1,5),new Positon(1,6)},
        {new Positon(2,3),new Positon(2,4), new Positon(2,5),new Positon(2,6)},
        {new Positon(3,3),new Positon(3,4), new Positon(3,5),new Positon(3,6)}
        };
        public int this[int i, int j]{
            get{
                return grid[i, j];
            }
            set{
                grid[i, j] = value;
                I = i;
                J = j;
            }
        }
        public int I { get; set; }
        public int J { get; set; }
        void resetOldRotation(int index, BlockQueue blockList, Positon[,] startArr, GameGrid arr){
            int column;
            int row;
            if (index == 0){
                index = 4;
            }
            for (int i = 0; i < 4; i++){
                //Reset-old-columns---------------------------------------------------------------
                column = startArr[0, 0].Column + blockList.NextBlock.blockArr[index - 1, i].Column + Settings.moveIncrement;
                row = startArr[0, 0].Row + blockList.NextBlock.blockArr[index - 1, i].Row + Settings.fallIncrement;
                arr.ActiveCell[column, row] = 0;
                //================================================================================
            }
        }
        public void rotateGameObject(Positon[,] startArr,BlockQueue blockList,int index,GameGrid arr){
            if (!Settings.rotatelocked || Settings.newGameObject){
                int column;
                int row;
                resetOldRotation(index, blockList, startArr, arr);
                for (int i = 0; i < 4; i++){
                    column = startArr[0, 0].Column + blockList.NextBlock.blockArr[index, i].Column + Settings.moveIncrement;
                    row = startArr[0, 0].Row + blockList.NextBlock.blockArr[index, i].Row + Settings.fallIncrement;
                    arr.ActiveCell[column, row] = Settings.gameIndex + 1;
                }
            }
        }
        public bool moveCell(GameGrid arr,bool left,bool right){
           
                if (left){
                    
                    MoveLeft(arr);
                    return true;
                }
                if (right){
                    MoveRight(arr);
                    return true;
                }
            
            return false;
        }
        void MoveLeft(GameGrid arr){
            int value = -1;
            bool incrementCounted = false;
            for (int i = 0; i < 10; i++){
                for (int j = 14; j >= 0; j--){
                    if (arr.ActiveCell[i, j] != 0 && arr.ActiveCell[i, j] != 10){
                        if (i == 0) return;
                        if (arr.ActiveCell[i - 1, j] == 10) return;
                        if (!incrementCounted){
                            incrementCounted = true;
                            Settings.moveIncrement--;
                        }
                        arr.ActiveCell[i + value, j] = arr.ActiveCell[i, j];
                        arr.ActiveCell[i, j] = 0;
                    }
                }
            }
        }
        void MoveRight(GameGrid arr){
            int value = 1;
            bool incrementCounted = false;
            for (int i = 9; i >= 0; i--){
                for (int j = 14; j >= 0; j--){
                    if (arr.ActiveCell[i, j] != 0 && arr.ActiveCell[i, j] != 10){
                        if (i == 9) return;
                        if (arr.ActiveCell[i + 1,j] == 10) return;
                        if (!incrementCounted){
                            incrementCounted = true;
                            Settings.moveIncrement++;
                        }
                        arr.ActiveCell[i + value, j] = arr.ActiveCell[i, j];
                        arr.ActiveCell[i, j] = 0;
                    }
                }
            }
        }
        public void makeRotateBlocking(GameGrid arr){
            if(Settings.moveIncrement >= 3 || Settings.moveIncrement <= -1 || Settings.fallIncrement >= 9){
                Settings.rotatelocked = true;
            }
            else{
               Settings.rotatelocked = false;
            }
        
        }
        public void fallCell(GameGrid arr){
            if (nextFallAllowed(arr)){
                for (int i = 9; i >= 0; i--){
                    for (int j = 14; j >= 0; j--){
                        if (arr.ActiveCell[i, j] != 0 && arr.ActiveCell[i, j] != 10){
                            arr.ActiveCell[i, j + 1] = arr.ActiveCell[i, j];
                            arr.ActiveCell[i, j] = 0;
                        }
                    }
                }
            }
            checkGameOver(arr);
        }
        bool nextFallAllowed(GameGrid arr){
            for(int i = 9; i >= 0; i--){
                for(int j = 14; j >= 0; j--){
                    if (arr.ActiveCell[i,j] != 0 && arr.ActiveCell[i,j] != 10){
                        if(j != 14){
                           if(arr.ActiveCell[i,j + 1] == 10){
                                makePositionFixed(arr);
                                return false;
                           } 
                        }
                        else{
                            makePositionFixed(arr);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        void checkGameOver(GameGrid arr){
            for(int i = 0; i < 10; i++){
                for (int j = 0; j < 4; j++){
                    if (arr.ActiveCell[i,j] == 10){
                        Settings.gameOver = true;
                    }
                }
            
            }
        }
        public void makePositionFixed(GameGrid arr){
            for (int i = 9; i >= 0; i--){
                for (int j = 14; j >= 0; j--){
                    if (arr.ActiveCell[i, j] != 0 && arr.ActiveCell[i,j] != 10){
                        arr.ActiveCell[i, j] = 10;
                    }
                }
            }
            arr.clearFullRows();
            //reset-Settings------------------------
            Settings.moveIncrement = 0;
            Settings.fallIncrement = 0;
            Settings.gameIndex++;
            if (Settings.gameIndex == 7){
                Settings.gameIndex = 0;
            }
            Settings.newGameObject = true;
            Settings.rotatelocked = false;
            //=======================================
        }
        public bool isRowFull(int row){
            for(int i = 0; i < grid.GetLength(0); i++){
              if(grid[i, row] == 0){
                    return false;
                }
            }
            return true;
        }
  
    }
}
