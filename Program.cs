using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            File smpx = new File();

            smpx.Create(smpx,"music.smpx", "% userprofile %\\library\\");
            Console.ReadKey();

            smpx.Save("i need you too.smpx");
            Console.ReadKey();

            smpx.Show();
            Console.ReadKey();
                       
           
        }
        
         
        
    }
}
