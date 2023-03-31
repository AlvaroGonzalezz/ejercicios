using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iniciador iniciador= new Iniciador();
            iniciador.Registrar();
            iniciador.IniciarSesion();
            Console.ReadKey();
        }
    }
}
