using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wait
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int seconds;
                if (int.TryParse(args[0], out seconds))
                {
                    Console.WriteLine("Going to wait for " + seconds + " seconds ... ");
                    for (int i = 1; i <= seconds; i++)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        if (i % 60 == 0) Console.WriteLine( " " + Math.Floor(i / 60.0) + " min");
                    }

                }
            }
            #pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
            #pragma warning restore CS0168 // Variable is declared but never used
            {
                Console.WriteLine("Please provide a valid number of seconds to wait!");
            }
        }
    }
}
