using System;

namespace FPU2_Ejemplo4_Alvaro
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameApp = "Aplicacion de Registro \n";
            // personalizar

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = nameApp;
            Console.Clear();

            // formulario de registro
            // declaracion de variables


            string nombre, apellidoPaterno, apellidoMaterno, email, telefonoCelular, domicilio;
            byte edad;
            char genero;
            double ahorroTotal;
            uint numeroSeguro;
            decimal altura;
            float codigoPostal;


            // asignar valor despues de declarlas de manera dinamica 



            Console.WriteLine(nameApp);
            Console.WriteLine("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu apellido paterno: ");
            apellidoPaterno = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu apellido materno: ");
            apellidoMaterno = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu correo electrónico: ");
            email = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu número de telefono: ");
            telefonoCelular = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu domicilio: ");
            domicilio = Console.ReadLine();
            Console.WriteLine("\n");



            Console.WriteLine("Escribe tu edad: \n");
            edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu genero: (M = Masculino, F = Femenino) ");
            genero = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tus ahorros totales: ");
            ahorroTotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu número de seguro: ");
            numeroSeguro = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu estatura en metros: ");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Escribe tu codigo postal: ");
            codigoPostal = Convert.ToSingle( Console.ReadLine());
            Console.WriteLine("\n");


            // imprima en consola las variables 

            Console.WriteLine("\n \t \t Datos del Usuario \n");
            Console.WriteLine("Nombre del Usuario: {0} {1} {2}.", nombre, apellidoPaterno, apellidoMaterno);
            Console.WriteLine("Edad: {0} años", edad);
            Console.WriteLine("Genero: {0}", genero);
            Console.WriteLine("Estatura (en metros): {0} metros", altura);
            Console.WriteLine("Número de teléfono: {0}", telefonoCelular);
            Console.WriteLine("Correo electónico: {0}", email);
            Console.WriteLine("Domicilio: {0}", domicilio);
            Console.WriteLine("Codigo Postal: {0}", codigoPostal);
            Console.WriteLine("Número de seguro: {0}", numeroSeguro);
            Console.WriteLine("Ahorros totales: ${0} ", ahorroTotal);









            Console.ReadKey();
        }
    }
}
