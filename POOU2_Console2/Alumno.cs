using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace POOU2_Console2
{
     class Alumno
    {

        #region Campos
        // Campos 

        // Detalles escolares
        string matriculaAlumno, nombreCarreraAlumno, semestreAlumno, fichaAlumno, nombreBachilleratoAlumno, correoInstitucionalAlumno;
            DateTime fechaIngresoAlumno;


            // Detalles generales del alumno
            string nombreAlumno, primerApellidoAlumno, segundoApellidoAlumno, curpAlumno, numeroCelularAlumno, correoPersonalAlumno;
            string diaNacimientoAlumno, mesNacimientoAlumno, añoNacimientoAlumno;

            // Detalles de la direccion del alumno
            string calleAlumno, numCasaAlumno, coloniaAlumno, ciudadAlumno, cpAlumno, estadoAlumno, paisAlumno;

            // Detalles medicos del alumno
            string nssAlumno;
            char grupoSanguineoAlumno, rhAlumno;

           // Declaramos una constante
           const string numeroTec = "100";

           // Declaramos la variable que guardara solo la fecha de inscripcion y otra que solo el año
            string fechaInscripcion, añoInscripcion;

        
        #endregion

        
        #region Constructores
        // Constructores 

        public Alumno(string nombreAlumno, string primerApellidoAlumno, string segundoApellidoAlumno, string matriculaAlumno, string semestreAlumno, string nombreCarreraAlumno)
             {
            // Asignar la info de los parametros a los campos
            this.nombreAlumno= nombreAlumno;
            this.primerApellidoAlumno= primerApellidoAlumno;
            this.segundoApellidoAlumno= segundoApellidoAlumno;
            this.matriculaAlumno= matriculaAlumno;
            this.semestreAlumno= semestreAlumno;
            this.nombreCarreraAlumno= nombreCarreraAlumno;

            


             }
                  // Creamos otro constructor, a esto se le llama sobrecarga, y le ayuda a darle 
                  // más opciones al programador, solo aplica en metodos y constructores.

           public Alumno() // constructor vacio
        {

            
            // Este constructor sera para pedir los valores de inicio

            Console.WriteLine("---------Registro de alumnos------------");
            //Console.WriteLine("\nIngresa la matricula: ");
            //this.matriculaAlumno= Console.ReadLine();
            Console.WriteLine("Ingresa el nombre: ");
            this.nombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa el primer apellido: ");
            this.primerApellidoAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa el segundo apellido: ");
            this.segundoApellidoAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa la carrera: ");
            this.nombreCarreraAlumno = Console.ReadLine();

            this.fechaIngresoAlumno = DateTime.Now; // Obtenemos la fecha y hora de hoy
            this.fechaInscripcion = fechaIngresoAlumno.ToString().Substring(0, 10); // solo tomamos la fecha ya que la hora no nos interesa

            //Obtenemos solamente el año
            this.añoInscripcion = fechaInscripcion.Substring(8);

            //Generamos la matricula
            this.matriculaAlumno = añoInscripcion + "" + numeroTec + "" + Consecutivo.contador;
            Consecutivo.contador = Consecutivo.contador + 1;


            // Inicializamos el semestre como es de nuevo ingreso valdrá 1

            this.semestreAlumno = "1";
            
        }

        #endregion



        #region Propiedades
        // Propiedades 

        public string MatriculaAlumno
        {
            get { return matriculaAlumno; }
            set { matriculaAlumno = value; }
        }

        public string NombreAlumno
        {
            get { return nombreAlumno; }
             set { nombreAlumno = value; }
          // Se lo quitamos si no queremos que se le asigne valores durante el codigo
        }

        public string PrimerApellidoAlumno
        {
            get { return primerApellidoAlumno; }
            set { primerApellidoAlumno = value; }
        }

        public string SegundoApellidoAlumno
        {
            get { return segundoApellidoAlumno; }
            set { segundoApellidoAlumno = value; }
        }


        #endregion

        #region Metodos

        // Metodos

        //public void PedirInfo()
        //{
        //    Console.BackgroundColor = ConsoleColor.Green;
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.Clear();

        //    Console.WriteLine("\t \t RegistraTEC ");
        //    Console.WriteLine("Ingresa la matricula: ");
        //    MatriculaAlumno = Console.ReadLine();
        //    Console.WriteLine("Ingresa tu nombre(s): ");
        //    NombreAlumno = Console.ReadLine();
        //    Console.WriteLine("Ingresa tu primer apellido: ");
        //    PrimerApellidoAlumno = Console.ReadLine();
        //    Console.WriteLine("Ingresa tu segundo apellido: ");
        //    SegundoApellidoAlumno = Console.ReadLine();


        // La comente porque estamos usando constructores vacios


        //}

        public void MostrarInfo()
        {
            

            Console.WriteLine("\t \t Sistema-Tec");
            Console.WriteLine("Matricula: {0} \n Nombre: {1} {2} {3}", matriculaAlumno, nombreAlumno, primerApellidoAlumno, segundoApellidoAlumno);
            Console.WriteLine("La fecha de ingreso es: {0}", fechaInscripcion);
            Console.WriteLine("Matricula: {0}", matriculaAlumno);
            Console.WriteLine("Semestre: {0}", semestreAlumno);
            
        }

        #endregion



    }
}
