using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris.Class_Folder
{
    public abstract class Block{
      public Block(){
        }
        public int row{get; set;}
        public int column{get; set;}
        public abstract Positon[,] blockArr { get; }
    }
}
