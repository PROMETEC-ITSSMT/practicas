using System;
namespace Laura
{
    class Suma
    {
        public int a; 
        // Constructor con un parametro
        public Suma()
        {
            Console.WriteLine("Constructor sin parametros");
        }
        // Constructor con dos parametros
        public Suma(int a) {
            this.a = a;
            Console.WriteLine("Constructor con un parametro: {0} " , a);
        }
        // Metodo de suma
        public int suma_2num(int num1, int num2) {
            int resultado = num1 + num2 + this.a;

            return resultado; 
        }
    }
}
