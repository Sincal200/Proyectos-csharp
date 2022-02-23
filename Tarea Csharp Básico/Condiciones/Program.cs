using System;

namespace Sentencias
{
    class SentenciaIf
    {
        public static void Main(string[] args)
        {
            int numeroEntero = int.Parse(Console.ReadLine());

            if(numeroEntero == 7)
                Console.WriteLine("numeroEntero es 7.");
            else if(numeroEntero < 0)
                Console.WriteLine("numeroEntero es negrativo");
            else
                Console.WriteLine("numeroEntero no es un ninguno de los casos programados"); 
        }
    }
}
