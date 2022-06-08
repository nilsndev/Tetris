using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tetris.Class_Folder{
    public class OBlock : Block{
        Positon[,] mdposArr = new Positon[,]{
        {new Positon(1,1), new Positon(1,2), new Positon(2,1), new Positon(2,2)},
        {new Positon(1,1), new Positon(1,2), new Positon(2,1), new Positon(2,2)},
        {new Positon(1,1), new Positon(1,2), new Positon(2,1), new Positon(2,2)},
        {new Positon(1,1), new Positon(1,2), new Positon(2,1), new Positon(2,2)}


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
 
