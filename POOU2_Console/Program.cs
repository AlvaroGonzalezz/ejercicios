using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Casa objetoCasa4 = new Casa();

            // Usamos el objeto creado
            //objetoCasa1.nombreDuenoCasa = "Alvaro";

            // Usamos la propiedad que protege a un campo
            objetoCasa1.PrecioVentaCasa = 1120000;

            // Usamos las demas propiedades (presencial)

            // Objeto 1
            objetoCasa1.NombreDuenoCasa = "Alvaro";
            objetoCasa1.ApellidosDuenoCasa = "Sanchez González";
            objetoCasa1.ColorCasa = ConsoleColor.Green;
            objetoCasa1.CalleCasa = "Solidaridad";
            objetoCasa1.NumCasa = "412";
            objetoCasa1.ColoniaCasa = "San Isidro (Los 2 Carnales)";
            objetoCasa1.CpCasa = "27850";
            objetoCasa1.CiudadCasa = "San Pedro";
            objetoCasa1.EstadoCasa = "Coahuila";
            objetoCasa1.PrecioVentaCasa = 1200000;
            objetoCasa1.MaterialCasa = "Ladrillo";
            objetoCasa1.NumHabitacionesCasa = 5;
            objetoCasa1.NumBañosCasa = 2;

            // Objeto 2
            objetoCasa2.NombreDuenoCasa = "Sergio";
            objetoCasa2.ApellidosDuenoCasa = "Prado Lozano";
            objetoCasa2.ColorCasa = ConsoleColor.Red;
            objetoCasa2.CalleCasa = "9 de Mayo";
            objetoCasa2.NumCasa = "22";
            objetoCasa2.ColoniaCasa = "Centro";
            objetoCasa2.CpCasa = "27800";
            objetoCasa2.CiudadCasa = "Torreón";
            objetoCasa2.EstadoCasa = "Coahuila";
            objetoCasa2.PrecioVentaCasa = 1000000;
            objetoCasa2.MaterialCasa = "Block";
            objetoCasa2.NumHabitacionesCasa = 6;
            objetoCasa2.NumBañosCasa = 1;


            // Objeto 3
            objetoCasa3.NombreDuenoCasa = "Joaquin";
            objetoCasa3.ApellidosDuenoCasa = "Guzman Loera";
            objetoCasa3.ColorCasa = ConsoleColor.Blue;
            objetoCasa3.CalleCasa = "Independencia";
            objetoCasa3.NumCasa = "252";
            objetoCasa3.ColoniaCasa = "Barrancos";
            objetoCasa3.CpCasa = "25600";
            objetoCasa3.CiudadCasa = "Culiacan";
            objetoCasa3.EstadoCasa = "Sinaloa";
            objetoCasa3.PrecioVentaCasa = 20000000;
            objetoCasa3.MaterialCasa = "Ladrillo";
            objetoCasa3.NumHabitacionesCasa = 8;
            objetoCasa3.NumBañosCasa = 3;

            // Objeto 4
            objetoCasa4.NombreDuenoCasa = "Ismael";
            objetoCasa4.ApellidosDuenoCasa = "Zambada";
            objetoCasa4.ColorCasa = ConsoleColor.Yellow;
            objetoCasa4.CalleCasa = "Miguel Gallardo";
            objetoCasa4.NumCasa = "1082";
            objetoCasa4.ColoniaCasa = "Las Rosas";
            objetoCasa4.CpCasa = "22900";
            objetoCasa4.CiudadCasa = "Mazatlán";
            objetoCasa4.EstadoCasa = "Sinaloa";
            objetoCasa4.PrecioVentaCasa = 90000000;
            objetoCasa4.MaterialCasa = "Block";
            objetoCasa4.NumHabitacionesCasa = 12;
            objetoCasa4.NumBañosCasa = 4;



            // Mandamos a pantalla usando las propiedades

            // Console.WriteLine("Nombre: {0}", objetoCasa1.NombreDuenoCasa);






            // Mandamos a pantalla usando el metodo
            objetoCasa1.MostrarInfo();
            objetoCasa2.MostrarInfo();
            objetoCasa3.MostrarInfo();
            objetoCasa4.MostrarInfo();





            Console.ReadKey();


        }
    }
}
