using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris.Class_Folder{
     public class SBlock : Block{
        Positon[,] mdposArr = new Positon[,]{
        {new Positon(0,1), new Positon(0,2), new Positon(1,0), new Positon(1,1)},
        {new Positon(0,1), new Positon(1,1), new Positon(1,2), new Positon(2,2)},
        {new Positon(1,1), new Positon(1,2), new Positon(2,0), new Positon(2,1)},
        {new Positon(0,0), new Positon(1,0), new Positon(1,1), new Positon(2,1)},
        };
        public override Positon[,] blockArr
        {
            get
            {
                return mdposArr;
            }
        }
    }
}
