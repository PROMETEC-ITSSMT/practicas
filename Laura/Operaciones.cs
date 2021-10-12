using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laura
{
    class Operaciones
    {
        static void Main(string[] args)
        {
            Suma suma1 = new Suma();


            Suma suma2 = new Suma(2);


            int resulatdoSuma1 = suma2.suma_2num(2, 3);

            Console.WriteLine(resulatdoSuma1);
        }
    }
}
