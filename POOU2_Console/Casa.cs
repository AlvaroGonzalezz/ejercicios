using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2_Console
{
     class Casa
    {
        // Miembros de una clase 
        // Campos: Son las variables que usaremos y se crean dentro de la clase
        public string materialCasa, nombreDuenoCasa, apellidoDuenoCasa, ubicacionCasa, metrosCuadradosCasa;
        double precioVentaCasa;
        byte numHabitacionesCasa, numBañosCasa, numPuertasCasa;
        ConsoleColor colorCasa;

        // Propiedades: Cuida a una variable y guarda informacion en un campo
      
        public byte NumBañosCasa
        {
            get { return numBañosCasa; }
            set { numBañosCasa = value; }
        }

        // Tarea: Crear una propiedad para colorCasa y precioVentaCasa

        public ConsoleColor ColorCasa
        {
            get { return colorCasa; }
            set { colorCasa = value;}
        }

        public double PrecioVentaCasa
        {
            get { return precioVentaCasa; }
            set { precioVentaCasa = value; }
        }
    }
}
