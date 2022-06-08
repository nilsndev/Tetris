using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris.Class_Folder
{
    public class BlockQueue
    {
        Random random = new Random();
        
        private readonly Block[] blocks = new Block[]{
        new IBlock{},
        new JBlock{},
        new LBlock{},
        new TBlock{},
        new ZBlock{},
        new SBlock{},
        new OBlock{},
   };

        public Block NextBlock{ 
            get{
                return blocks[Settings.gameIndex];
            }
            set{
                NextBlock = blocks[Settings.gameIndex];
            } 
        }


       

    }

   
}
