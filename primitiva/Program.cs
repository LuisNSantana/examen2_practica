using System;

namespace primitiva
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            int[] numUsuario = new int[6];
            int[] numAl = new int[6];
            int numRand;
            int cont = 0;
            int temp = 0;

            while (cont == 0)
            {
                for (int i = 0; i < numUsuario.Length; i++)
                {
                    Console.WriteLine("Ingrese un numero: ");
                    numUsuario[i] = Convert.ToInt32(Console.ReadLine());
                    numRand = rand.Next(1, 50);
                    numAl[i] = numRand;
                    

                     if (numUsuario[i] > 49)
                    {
                        
                        Console.WriteLine("introduzca un numero menor");
                        numUsuario[i] = numUsuario[i --];
                        
                    }else if ( numUsuario[i] == 0)
                    {
                        Console.WriteLine("introduzca un numero mayor");
                        numUsuario[i] = numUsuario[i--];
                    }





                }

               
                    if (numUsuario[0] == numAl[0])
                    {
                        cont++;
                        Console.WriteLine("Ha acertado este numero: " + numUsuario[0]);
                    }
                    if (numUsuario[1] == numAl[1])
                    {
                        cont++;
                        Console.WriteLine("Ha acertado este numero: " + numUsuario[1]);
                    }
                    if (numUsuario[2] == numAl[2])
                    {
                        cont++;
                        Console.WriteLine("Ha acertado este numero: " + numUsuario[1]);
                    }
                    if (numUsuario[3] == numAl[3])
                    {
                        cont++;
                        Console.WriteLine("Ha acertado este numero: " + numUsuario[3]);
                    }
                    if (numUsuario[4] == numAl[4])
                    {
                        cont++;
                        Console.WriteLine("Ha acertado este numero: " + numUsuario[4]);
                    }
                    if (numUsuario[5] == numAl[5])
                    {
                        cont++;
                        Console.WriteLine("Ha acertado este numero: " + numUsuario[5]);
                    }


                
                Console.WriteLine("El numero de aciertos han sido: " + cont);
            }
        }
    }
}
