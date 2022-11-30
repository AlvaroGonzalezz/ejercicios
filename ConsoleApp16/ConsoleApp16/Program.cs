using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FPU3_A1_Alvaro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int promedioAlumno = 0;
            // Declaramos un arreglo
            int it = 0; // variable que usaremos en el foreach
            int[] calif = new int[6];

            // otro metodo de declaracion del arreglo puede ser:
            int[] califs2;
            // y declaramos ya otra vez debajo de cuando lo pedimos

            //// For para llenar
            for (int i = 0; i < calif.Length; i++)
            {
                Console.WriteLine("Ingresa la calificacion de la unidad {0}: ", i + 1);
                calif[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < calif.Length; i++)
            {
                Console.WriteLine("La calificaciones de la unidad {0} es {1}", i + 1, calif[i]);



            }


            //// Operaciones sobre Arreglos
            //// Ordena los valores de menor a mayor cualquier tipo de dato
            //Array.Sort(calif);



            //// Uso de Foreach
            //// Se divide en dos partes, la declaracion del variable con el mismo tipo de datos y en la otra parte iria el nombre como arreglo
            foreach (int resultados in calif)
            {

                it++;
                // Mostrar los valores
                Console.WriteLine("Calificacion de unidad {0} es {1}", it, resultados);

            }

            foreach (int califs in calif)
            {
                // promedio = promedioAlumno + califs;
                promedioAlumno += califs; // += es un operador que es igual a la linea anterior

            }


            //// Leer todos los elementos de un arreglo


            #region Programa

            // Sistema de Votos de elecciones
            // Personalizamos la consola
            //Console.Title = "Sistema Electoral";
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.WindowHeight = 30;
            //Console.WindowWidth = 150;
            //Console.Clear();
            //// Declaramos variables
            //string respuestaUsuario, respuestaVoto;
            //int votos1 = 0, votos2 = 0, votos3 = 0, votos4 = 0, votos5 = 0;
            //double numeroVotos, porcentaje1, porcentaje2, porcentaje3, porcentaje4, porcentaje5;


            //// Mandamos a pantalla informacion del programa
            //Console.WriteLine("\t \t \t Votos de un acto Electoral");


            //Console.WriteLine("¿Deseas votar por un candidato? (Si/No)");
            //respuestaUsuario = Console.ReadLine();



            //while (respuestaUsuario == "si" || respuestaUsuario == "Si" || respuestaUsuario == "SI")
            //{
            //    Console.WriteLine("Para votar al candidato número 1 pulse la tecla 1");
            //    Console.WriteLine("Para votar al candidato número 2 pulse la tecla 2");
            //    Console.WriteLine("Para votar al candidato número 3 pulse la tecla 3");
            //    Console.WriteLine("Para votar al candidato número 4 pulse la tecla 4");
            //    Console.WriteLine("Para votar al candidato número 5 pulse la tecla 5");
            //    respuestaVoto = Console.ReadLine();

            //    switch (respuestaVoto)
            //    {
            //        case "1":
            //            Console.WriteLine("Votaste por el candidato número 1");
            //            votos1 = votos1 + 1;
            //            break;
            //        case "2":
            //            Console.WriteLine("Votaste por el candidato número 2");
            //            votos2 = votos2 + 1;
            //            break;
            //        case "3":
            //            Console.WriteLine("Votaste por el candidato número 3");
            //            votos3 = votos3 + 1;
            //            break;
            //        case "4":
            //            Console.WriteLine("Votaste por el candidato número 4");
            //            votos4 = votos4 + 1;
            //            break;
            //        case "5":
            //            Console.WriteLine("Votaste por el candidato número 5");
            //            votos5 = votos5 + 1;
            //            break;

            //        default:
            //            Console.WriteLine("No existe ningun candidato con ese número, vuelve a votar.");

            //            break;
            //    }
            //    Console.WriteLine("¿Deseas votar nuevamente por un candidato? (Para detener el conteo pulsa la tecla = 0)");
            //    respuestaUsuario = Console.ReadLine();
            //}

            //// calculamos el total de votos y porcentaje de cada votente
            //numeroVotos = votos1 + votos2 + votos3 + votos4 + votos5;

            //porcentaje1 = (votos1 / numeroVotos) * 100;
            //porcentaje2 = (votos2 / numeroVotos) * 100;
            //porcentaje3 = (votos3 / numeroVotos) * 100;
            //porcentaje4 = (votos4 / numeroVotos) * 100;
            //porcentaje5 = (votos5 / numeroVotos) * 100;


            //// mostramos los numeros de votos de cada candidato
            //Console.WriteLine("El candidato número 1 obtuvo un total de {0} votante(s) con un {1}%  del total de los votantes", votos1, porcentaje1);
            //Console.WriteLine("El candidato número 2 obtuvo un total de {0} votante(s) con un {1}%  del total de los votantes", votos2, porcentaje2);
            //Console.WriteLine("El candidato número 3 obtuvo un total de {0} votante(s) con un {1}%  del total de los votantes", votos3, porcentaje3);
            //Console.WriteLine("El candidato número 4 obtuvo un total de {0} votante(s) con un {1}%  del total de los votantes", votos4, porcentaje4);
            //Console.WriteLine("El candidato número 5 obtuvo un total de {0} votante(s) con un {1}%  del total de los votantes", votos5, porcentaje5);
            //Console.WriteLine("Pulsa la tecla ENTER para salir..");

            #endregion

            Console.ReadKey();
        }
    }
}