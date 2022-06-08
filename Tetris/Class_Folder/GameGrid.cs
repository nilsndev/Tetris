using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris.Class_Folder{
   public class GameGrid{
        private Cell cell = new Cell();
        public  Cell ActiveCell{
            get{return cell;}
        }
        public void clearFullRows(){
            for(int i = 0; i<15; i++){
                if (ActiveCell.isRowFull(i)){
                    clearRow(i);
                    moveDown(i);
                }
            }
        }

        public void clearRow(int r){
            for(int i =0; i< 10; i++){
                ActiveCell[i, r] = 0;
            }
            Settings.Cleared++;
        }
        public void moveDown(int r){
            for (int i = 9; i >= 0; i--){
                for(int j=r;j >= 0; j--){
                    if (ActiveCell[i, j] == 10 && j != 14){
                        ActiveCell[i, j] = 0;
                        ActiveCell[i, j + Settings.Cleared] = 10;
                    }
                    
                }
               
            }
            Settings.Cleared = 0;
        }
    }
}
