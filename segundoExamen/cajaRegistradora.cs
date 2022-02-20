using System;

namespace segundoExamen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int articulo = 0;
            string nuevoCalc ="";
            int aux = 0;
            int cliente = 0;
            int resta = 0;
           
            

            do
            {
                Console.WriteLine("Cual es el precio del articulo (Pulsa 0 para fin): ");
                articulo = Convert.ToInt32(Console.ReadLine());
                aux += articulo;
                Console.WriteLine("El importe actual " + aux);




                if (articulo == 0)
                {
                    Console.WriteLine("El importe total es de: " + aux);


                    Console.WriteLine("El cliente paga con: ");
                    cliente = Convert.ToInt32(Console.ReadLine());

                    resta = cliente - aux;
                    Console.WriteLine("El cambio es de: " + resta);
                    aux = 0;

                    Console.WriteLine("Quiere realizar un nuevo calculo? (y/n) ");

                    nuevoCalc = Console.ReadLine();

                }
                if (nuevoCalc == "y")
                {
                    
                }
                else if (nuevoCalc == "n")
                {
                    Console.Write("Ha finalizado");
                }



                


            } while (articulo!=0 || nuevoCalc == "y");


           

        }
    }
}
