using System;


namespace Cap_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;


            Console.WriteLine("Bienvenido al Menu");
            Console.WriteLine("1.Fecha");
            Console.WriteLine("2.Producto");
            Console.WriteLine("3.Dueno");
            Console.WriteLine("4.Neumaticos");
            Console.WriteLine("Elija una opcion");
            op = Convert.ToInt32(Console.ReadLine());


            switch (op)
            {


                case 1:
                    {
                        Ejercicio8_3.Fecha();
                        break;
                    }
                

                case 2:
                     {
                         Ejercicio9_1.Tienda();
                        break;
                     }
              
                    case 3:
                     {
                         Ejercicio9_3.Dueno_Mascota();
                         break;
                     }
               

                    case 4:
                     {
                        Ejercicio9_4.Gomas();
                        break;
                     }
                     
                default:
                    {
                        Console.WriteLine("Esta opcion no existe");
                        break;
                    }

            }
        }
    }
}