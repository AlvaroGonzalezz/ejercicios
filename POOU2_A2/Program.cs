using System;

namespace POOU2_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia
            Cuenta cuenta1= new Cuenta();
            
            
            // Asignamos el metodo a nuestro objeto
            cuenta1.MostrarInformacion();
         

            // Para no cerrar la pantalla
            Console.ReadKey();

        }
    }
}
