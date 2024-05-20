using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.DecoracionEscritura
{
    internal class EscrituraApp
    {
        public void DecoracionEscritura()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@" _______  ___   _______  _______  _______  __   __  _______    
|       ||   | |       ||       ||       ||  |_|  ||   _   |   
|  _____||   | |  _____||_     _||    ___||       ||  |_|  |   
| |_____ |   | | |_____   |   |  |   |___ |       ||       |   
|_____  ||   | |_____  |  |   |  |    ___||       ||       |   
 _____| ||   |  _____| |  |   |  |   |___ | ||_|| ||   _   |   
|_______||___| |_______|  |___|  |_______||_|   |_||__| |__|   
 ______   _______                                              
|      | |       |                                             
|  _    ||    ___|                                             
| | |   ||   |___                                              
| |_|   ||    ___|                                             
|       ||   |___                                              
|______| |_______|                                             
 _______  ___   _______  ___   _  _______  _______  _______    
|       ||   | |       ||   | | ||       ||       ||       |   
|_     _||   | |       ||   |_| ||    ___||_     _||  _____|   
  |   |  |   | |       ||      _||   |___   |   |  | |_____    
  |   |  |   | |      _||     |_ |    ___|  |   |  |_____  |   
  |   |  |   | |     |_ |    _  ||   |___   |   |   _____| |   
  |___|  |___| |_______||___| |_||_______|  |___|  |_______|   ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ResetColor();
        }
    }
}
