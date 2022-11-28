using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FPU3_A2_Alvaro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Control meteorológico de Ensenada, Baja California
            // Personalizamos la consola
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 30;
            Console.WindowWidth = 100;
            Console.Title = "Centro Meterológico de Ensenada";
            Console.Clear();

            // Declaramos la variables que usaremos
            string respuestaUsuario, respuestaUsuario2;
            int promedioMensualNorte = 0, sumaNorte = 0, promedioMensualSur = 0, sumaSur = 0, promedioMensualCentro = 0, sumaCentro = 0,
                promedioMensualGolfo = 0 , sumaGolfo = 0, promedioMensualPacifico = 0, sumaPacifico = 0, promedioMensualCaribe = 0, sumaCaribe = 0, promedioAnualNorte = 0, promedioAnualSur = 0,
                promedioAnualCentro = 0, promedioAnualGolfo = 0, promedioAnualPacifico = 0, promedioAnualCaribe = 0;
            int maxTempNorte = 0;
            // Pedimos los datos 
            Console.WriteLine("\t \t \t Bienvenido al Centro Meteorológico de Ensenada, Baja California.");
            Console.WriteLine("Buenos días, ¿Deseas iniciar el registro de temperatura? (Si/No)");
            respuestaUsuario = Console.ReadLine();
            // usamos if para entrar al registro 
            while (respuestaUsuario == "Si" || respuestaUsuario == "si" || respuestaUsuario == "SI")
            {

                Console.WriteLine("¿En que región deseas registrar el promedio de la temperatura mensual? Norte, Sur, Centro, Golfo, Pacífico o Caribe");
                respuestaUsuario2 = Console.ReadLine();

                //Usamos switch para las regiones y dentro de case for para pedir el registro mensual de cada region

                switch (respuestaUsuario2)
                {
                    case "Norte":
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            
                            Console.WriteLine("Por favor introduce el promedio de temperatura en grados de la región Norte del mes {0} del año:", mes);
                            promedioMensualNorte = Convert.ToSByte(Console.ReadLine());
                            if (promedioMensualNorte > promedioMensualNorte)
                            {
                                maxTempNorte = promedioMensualNorte;
                            }
                            sumaNorte = Convert.ToInt32(sumaNorte + promedioMensualNorte);
                        }
                        Console.WriteLine("¿Deseas continuar con el registro? (Si/No)");
                        respuestaUsuario = Console.ReadLine();
                        break;
                    case "Sur":
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            Console.WriteLine("Por favor introduce el promedio de temperatura en grados de la región Sur del mes {0} del año:", mes);
                            promedioMensualSur = Convert.ToSByte(Console.ReadLine());
                            sumaSur = Convert.ToInt32(sumaSur + promedioMensualSur);
                        }
                        Console.WriteLine("¿Deseas continuar con el registro? (Si/No)");
                        respuestaUsuario = Console.ReadLine();
                        break;

                    case "Centro":
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            Console.WriteLine("Por favor introduce el promedio de temperatura en grados de la región Centro del mes {0} del año:", mes);
                            promedioMensualCentro = Convert.ToSByte(Console.ReadLine());
                            sumaCentro = Convert.ToInt32(sumaCentro + promedioMensualCentro);
                        }
                        Console.WriteLine("¿Deseas continuar con el registro? (Si/No)");
                        respuestaUsuario = Console.ReadLine();
                        break;
                    case "Golfo":
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            Console.WriteLine("Por favor introduce el promedio de temperatura en grados de la región Golfo del mes {0} del año:", mes);
                            promedioMensualGolfo = Convert.ToSByte(Console.ReadLine());
                            sumaGolfo = Convert.ToInt32(sumaGolfo + promedioMensualGolfo);
                        }
                        Console.WriteLine("¿Deseas continuar con el registro? (Si/No)");
                        respuestaUsuario = Console.ReadLine();
                        break;
                    case "Pacifico":
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            Console.WriteLine("Por favor introduce el promedio de temperatura en grados de la región Pacífico del mes {0} del año:", mes);
                            promedioMensualPacifico = Convert.ToSByte(Console.ReadLine());
                            sumaPacifico = Convert.ToInt32(sumaPacifico + promedioMensualPacifico);
                        }
                        Console.WriteLine("¿Deseas continuar con el registro? (Si/No)");
                        respuestaUsuario = Console.ReadLine();
                        break;
                    case "Caribe":
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            Console.WriteLine("Por favor introduce el promedio de temperatura en grados de la región Caribe del mes {0} del año:", mes);
                            promedioMensualCaribe = Convert.ToSByte(Console.ReadLine());
                            sumaCaribe = Convert.ToInt32(sumaCaribe + promedioMensualCaribe);
                        }
                        Console.WriteLine("¿Deseas continuar con el registro? (Si/No)");
                        respuestaUsuario = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("No existe ninguna región con ese nombre, vuelve a intentarlo");
                        Console.WriteLine("Saliendo del sistema...");
                        Thread.Sleep(1000);
                        Console.WriteLine("Saliendo del sistema...");
                        Thread.Sleep(1000);
                        Console.WriteLine("Saliendo del sistema...");
                        Thread.Sleep(1000);
                        return;
                        
                }

               

            }
             if (respuestaUsuario == "no" || respuestaUsuario == "NO" || respuestaUsuario == "No")
            {

                
                // Calculamos los promedios anuales de cada region
                promedioAnualNorte = sumaNorte / 12;
                promedioAnualSur = sumaSur / 12;
                promedioAnualCentro = sumaCentro / 12;
                promedioAnualGolfo = sumaGolfo / 12;
                promedioAnualPacifico = sumaPacifico / 12;
                promedioAnualCaribe = sumaCaribe / 12;

                // Mandamos a pantalla el promedio anual de cada region
                Console.WriteLine("El promedio anual de temperatura de la region Norte es de {0} grados.", promedioAnualNorte);
                Console.WriteLine("El promedio anual de temperatura de la region Sur es de {0} grados.", promedioAnualSur);
                Console.WriteLine("El promedio anual de temperatura de la region Centro es de {0} grados.", promedioAnualCentro);
                Console.WriteLine("El promedio anual de temperatura de la region Golfo es de {0} grados.", promedioAnualGolfo);
                Console.WriteLine("El promedio anual de temperatura de la region Pacífico es de {0} grados.", promedioAnualPacifico);
                Console.WriteLine("El promedio anual de temperatura de la region Caribe es de {0} grados.\n", promedioAnualCaribe);

                // Mandamos a pantalla cual region tiene mas alta la temperatura al año

                if (promedioAnualNorte > promedioAnualSur && promedioAnualNorte > promedioAnualCentro && promedioAnualNorte > promedioAnualGolfo && promedioAnualNorte > promedioAnualPacifico && promedioAnualNorte > promedioAnualCaribe)
                {
                    Console.WriteLine("La región Norte tiene el promedio de temperatura al año más alto con {0} grados.", promedioAnualNorte);
                }
                else if (promedioAnualSur > promedioAnualNorte && promedioAnualSur > promedioAnualCentro && promedioAnualSur > promedioAnualGolfo && promedioAnualSur > promedioAnualPacifico && promedioAnualSur > promedioAnualCaribe)
                {
                    Console.WriteLine("La región Sur tiene el promedio de temperatura al año más alto con {0} grados.", promedioAnualSur);
                }
                else if (promedioAnualCentro > promedioAnualSur && promedioAnualCentro > promedioAnualNorte && promedioAnualCentro > promedioAnualGolfo && promedioAnualCentro > promedioAnualPacifico && promedioAnualCentro > promedioAnualCaribe)
                {
                    Console.WriteLine("La región Centro tiene el promedio de temperatura al año más alto con {0} grados.", promedioAnualCentro);
                }
                else if (promedioAnualGolfo > promedioAnualSur && promedioAnualGolfo > promedioAnualCentro && promedioAnualGolfo > promedioAnualNorte && promedioAnualGolfo > promedioAnualPacifico && promedioAnualGolfo > promedioAnualCaribe)
                {
                    Console.WriteLine("La región Golfo tiene el promedio de temperatura al año más alto con {0} grados.", promedioAnualGolfo);
                }
                else if (promedioAnualPacifico > promedioAnualSur && promedioAnualPacifico > promedioAnualCentro && promedioAnualPacifico > promedioAnualGolfo && promedioAnualPacifico > promedioAnualNorte && promedioAnualPacifico > promedioAnualCaribe)
                {
                    Console.WriteLine("La región Pacífico tiene el promedio de temperatura al año más alto con {0} grados.", promedioAnualPacifico);
                }
                else if (promedioAnualCaribe > promedioAnualSur && promedioAnualCaribe > promedioAnualCentro && promedioAnualCaribe > promedioAnualGolfo && promedioAnualCaribe > promedioAnualPacifico && promedioAnualCaribe > promedioAnualNorte)
                {
                    Console.WriteLine("La región Caribe tiene el promedio de temperatura al año más alto con {0} grados.", promedioAnualCaribe);
                }
            }

            




















            Console.ReadKey();
        }
    }
}
