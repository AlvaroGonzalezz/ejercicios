using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia
            Casa objetoCasa1 = new Casa();
            Casa objetoCasa2 = new Casa();
            Casa objetoCasa3 = new Casa();


            // Usamos el objeto creado
            objetoCasa1.nombreDuenoCasa = "Alvaro";

            // Usamos la propiedad que protege a un campo
            objetoCasa1.PrecioVentaCasa = 1120000;


            

        }
    }
}
