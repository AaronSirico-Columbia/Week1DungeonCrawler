using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveOfEnviorments
{
    public class Utility
    {
    
        //Sets color of text
        public void SetColor(ConsoleColor textColor = ConsoleColor.White, ConsoleColor blackColor = ConsoleColor.Black)
        {
            Console.ForegroundColor = textColor;
            Console.ForegroundColor = blackColor;
        }
    }
}
