using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris.Class_Folder
{
    public class Positon {

        public Positon(){ 
        }
        public Positon(int row,int column){
        Row = row;
        Column = column;
        }
        public int Row { get; set; }
        public int Column { get; set; }


      
    }
}
