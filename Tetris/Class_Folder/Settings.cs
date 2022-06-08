using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris.Class_Folder
{
   public static class Settings{

        public static int rotateCount{get; set;}
        public static bool gameOver{ get; set;}
        public static bool rotatelocked{get; set;}
        public static bool newGameObject{get; set;}
        public static int maxWidth{get; set;}
        public static int maxHeight{ get; set; }
        public static int Cleared{get; set;}
        public static int Width{get; set;}
        public static int Height{get; set;}
        public static int gameIndex {get; set;}
        public static int fallIncrement{get; set;}
        public static int moveIncrement{get; set;}
       
    }
}
