using System;

namespace buclesYmasBucles
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] vector = new int[10] { 2, 8, 4, 3, 4, 1, 8, 6, 3, 8 };
            int cont = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if(vector[i] == 4)
                {
                    cont++;
                }
            }
            Console.WriteLine("El numero total de cuatros que existen en el array son:" + cont);

            for(int i = 0; i < vector.Length -2; i++)
            {
                cont = vector[i] - 1;

                if(vector[i] == 3)
                {
                    Console.WriteLine("empezando desde la izquierda encontramos el 3 en la posicion: " +cont);
                }
            }
            for(int i = 0; i < vector.Length; i++)
            {
                

                if(vector[i] == 3)
                {
                    Console.WriteLine("Empezando desde la derecha lo encontramos el 3 en la posicion: " + vector[i]);
                }
            }

            Console.WriteLine("------vectores solo pares-----");
            for (int i = 0; i< vector.Length; i++)
            {
                
                
                if (vector[i]%2 == 0)
                {
                    

                    Console.Write(vector[i] + "|");


                }
            }

            Console.WriteLine("\n ------vectores solo impares-----");

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] % 2 != 0)
                {
                    

                    Console.Write(vector[i] + "|");


                }
            }

            
            
        }
    }
}
