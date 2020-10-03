using System;
using System.Text;

namespace Cap_8
{
    class Ejercicio9_3
    {
        public static void Dueno_Mascota(){
            Dueno dueno;
            String Nombre;
            String Direccion;
            String Telefono;
            


            Console.WriteLine("Digite el nombre del dueno:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Digite la direccion:");
            Direccion = Console.ReadLine();
            Console.WriteLine("Digite su numero de telefono:");
            Telefono = Console.ReadLine();


            dueno = new Dueno(Nombre, Direccion, Telefono);


            Console.WriteLine(dueno.ToString());
            
        }
        public struct Dueno
        {
            public String Nombre;
            public String Direccion;
            public String Telefono;

            public Dueno(String Nombre1, String Direccion1, String Telefono1)
            {
                Nombre = Nombre1;
                Direccion = Direccion1;
                Telefono = Telefono1;
            }

            public override string ToString()
            {
                StringBuilder sd = new StringBuilder();
                sd.AppendFormat("Nombre del Dueño: {0}, Telefono del Dueño: {2}, Dirección del Dueño: {1}", Nombre, Direccion, Telefono);
                return sd.ToString();
            }
        }

        public struct Mascota
        {
            public String Nombre;
            public String Raza;
            public Dueno Jefe;

            public Mascota(String NombreMascota, String Raza2, String NombreD, String DireccionD, String TelefonoD)
            {
                Nombre = NombreMascota;
                Raza = Raza2;
                Jefe = new Dueno(NombreD, DireccionD, TelefonoD);
            }

            public override string ToString()
            {
                StringBuilder sd = new StringBuilder();
                sd.AppendFormat("Nombre de la Mascota: {0}, Raza de la Mascota: {1}", Nombre, Raza);
                sd.Append(Jefe.ToString());
                return sd.ToString();
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}