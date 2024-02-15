using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace интерфейс
{
    class Program
    {
        static void Main(string[] args)
        {
            GeomProgression x = new GeomProgression();
            ArithProgression y = new ArithProgression();
            y.SetStart(1);
            y.SetStep(2);
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine(y.GetNext());
            }
            y.Reset();
            x.SetStart(1);
            x.SetStep(2);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(x.GetNext());
            }
            x.Reset();
            Console.WriteLine(x.GetNext());

            Console.ReadKey();
        }
    }
}
