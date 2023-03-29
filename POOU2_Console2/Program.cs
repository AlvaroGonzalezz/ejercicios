using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2_Console2
{
     class Program
    {
        static void Main(string[] args)
        {
            // Para colocar los parametros que los asigne el usuario declaramos las variables
            // y colocariamos las variables en los parametros de la instancia
            string nombre, primerApellido, carrera, semestre;
            // Aqui pediriamos las variables y las guardariamos 

            // Objetos 
            Alumno alumno1 = new Alumno(); // y aqui colocariamos las variables
            Alumno alumno2 = new Alumno();

            // Pedirle la info al usuario

            //Console.WriteLine("Ingresa la matricula: ");
            //alumno1.MatriculaAlumno = Console.ReadLine();
            //Console.WriteLine("Ingresa tu nombre(s): ");
            //alumno1.NombreAlumno = Console.ReadLine();
            //Console.WriteLine("Ingresa tu primer apellido: ");
            //alumno1.PrimerApellidoAlumno = Console.ReadLine();
            //Console.WriteLine("Ingresa tu segundo apellido: ");
            //alumno1.SegundoApellidoAlumno = Console.ReadLine();




            // Imprimir

            //  Console.WriteLine("Matricula: {0} \n Nombre: {1} {2} {3}", alumno1.MatriculaAlumno, alumno1.NombreAlumno, alumno1.PrimerApellidoAlumno, alumno1.SegundoApellidoAlumno);


            // Le asignamos los 2 metodos a cada objeto para que se imprima a pantalla
           // alumno1.PedirInfo();
         //   alumno2.PedirInfo();
            alumno1.MostrarInfo();
            alumno2.MostrarInfo();

            

            Console.ReadKey();

        }
    }
}
