using System;
using System.Collections.Generic;
using System.Text;

namespace _30._09._2019
{
    class figure: IDisposable
    {
        ConsoleColor color;
        public void Draw()
        {
            string logo = @"
                    ###      ###        ###      ###                  
                #           #             #             #           # 
             #           #    #      #    #      #    #           #
                #           #             #             #           # 
                    ###      ###       ###      ###
            ";
            Console.ForegroundColor = color;
            Console.WriteLine(logo);
        }
        public void SwichColor()
        {
            string buf;
            Console.WriteLine("Enter color=> ");
            buf=Console.ReadLine();
            color = ConsoleColor.Red;
        }
     
        public void Dispose()
        {
            Console.ResetColor();
        }
    }
}
