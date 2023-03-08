using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2_Console
{
     class Casa
    {

        #region MiembrosCampos
        // Miembros de una clase 
        // Campos: Son las variables que usaremos y se crean dentro de la clase
        string materialCasa, nombreDuenoCasa, apellidosDuenoCasa, calleCasa, coloniaCasa, cpCasa, numCasa, ciudadCasa, estadoCasa;
        double precioVentaCasa, engancheCasa;
        byte numHabitacionesCasa, numBañosCasa;
        ConsoleColor colorCasa;

        #endregion

        #region MiembrosPropiedades

        // Propiedades: Cuida a una variable y guarda informacion en un campo

        public byte NumBañosCasa
        {
            get { return numBañosCasa; }
            set { numBañosCasa = value; }
        }

        // Tarea: Crear una propiedad para colorCasa y precioVentaCasa


         public ConsoleColor ColorCasa
        {
            // Es el que obtiene la variable
            get { return colorCasa; } 

            // Es el que envia lo que contiene la variable 
            set { colorCasa = value;}
        }

        public double PrecioVentaCasa
        {
            get { return precioVentaCasa; }
            set { precioVentaCasa = value; }
        }

        // Propiedad para el campo de precioVentaIvaCasa

        public double PrecioVentaIvaCasa
        {
            get { return precioVentaIvaCasa; }
            set { precioVentaCasa = value; }
        }


        // Demas propiedades
        public string NombreDuenoCasa {
            get { return nombreDuenoCasa;}
            set { nombreDuenoCasa= value; }
            
            }

        public string ApellidosDuenoCasa
        {
            get { return apellidosDuenoCasa; }
            set { apellidosDuenoCasa= value; }
        }

        public byte NumHabitacionesCasa
        {
            get { return numHabitacionesCasa; }
            set { numHabitacionesCasa= value; }
        }

        public string MaterialCasa
        {
            get { return materialCasa; }
            set { materialCasa = value; }
        }

        public string CiudadCasa
        {
            get { return ciudadCasa; }
            set { ciudadCasa = value; }
        }

        public string EstadoCasa
        {
            get { return estadoCasa; }
            set { estadoCasa = value; }
        }

        public double EngancheCasa
        {
            get { return engancheCasa; }
            set { engancheCasa = value;}
        }

        // Creamos una propiedad para una variable que solo sera de lectura

        // public byte NumHabitaciones {

        //     get { return numHabitacionesCasa; }
        // }



        // Creamos una propiedad para las variables de ubicacion

        public string CalleCasa
        {
            get { return calleCasa; }
            set { calleCasa = value; }
        }
        public string ColoniaCasa
        {
            get { return coloniaCasa; }
            set { coloniaCasa = value; }
        }
        public string NumCasa
        {
            get { return numCasa; }
            set { numCasa = value; }
        }
        public string CpCasa
        {
            get { return cpCasa; }
            set { cpCasa = value; }
        }

        #endregion


        #region MiembrosConstructores

        public Casa (string nombreDuenoCasa, string apellidosDuenoCasa, ConsoleColor colorCasa, double engancheCasa)
        {
            this.nombreDuenoCasa= nombreDuenoCasa;
            this.apellidosDuenoCasa = apellidosDuenoCasa;
            this.colorCasa= colorCasa;
            this.engancheCasa= engancheCasa;

        }


        public Casa(string numCasa)
        {
            this.numCasa= numCasa;
        }

        #endregion


        #region MiembrosMetodos
        // Miembros: Metodos

        public void MostrarInfo()
        {
            // Cuerpo
            Console.ForegroundColor = ColorCasa;
            Console.WriteLine("\n\t Detalles del Dueño.");
            Console.WriteLine("\n Nombre y apellidos del Dueño: {0} {1}.", NombreDuenoCasa, ApellidosDuenoCasa);
            Console.WriteLine("\n\t Detalles de la Casa.");
            Console.WriteLine("\n Material de construcción: {0} -- Número de habitaciones: {1} -- Número de baños: {2}", MaterialCasa, NumHabitacionesCasa, NumBañosCasa);
            Console.WriteLine("\n\t Ubicación de la Casa");
            Console.WriteLine("\n Número: {0} -- Calle: {1} -- Colonia: {2} -- Código Postal: {3} -- Ciudad: {4} -- Estado: {5}", NumCasa, CalleCasa, ColoniaCasa, CpCasa, CiudadCasa, EstadoCasa );
            Console.WriteLine("\n\t Detalles de la Venta.");
            Console.WriteLine("\n Costo de la Casa: ${0} pesos -- Impuesto (IVA): ${1} -- Costo Total de la Casa: ${2} pesos -- Enganche: ${3} pesos \n \n", PrecioVentaCasa, PrecioVentaCasa * 0.16, PrecioVentaCasa + (PrecioVentaCasa*0.16), EngancheCasa); // la segunda variable hace referencia al precio con impuestos
        }


        #endregion



    }
}
