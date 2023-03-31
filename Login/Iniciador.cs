using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Login
{
     class Iniciador
    {
        // Campos
        string nombreUsuario, contraseñaUsuario, confirmarContraseñaUsuario;


        // Metodos
        public void Registrar()
        {
            Console.WriteLine("--------REGISTRO-----------");
            Console.WriteLine("Ingresa tu nombre de usuario a registrar: ");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Crea una contraseña: ");
            contraseñaUsuario= Console.ReadLine();
            Console.WriteLine("Repite de nuevo la contraseña: ");
            confirmarContraseñaUsuario= Console.ReadLine();
            if (contraseñaUsuario == confirmarContraseñaUsuario)
            {
                Console.WriteLine("Registro exitoso");
                // Iniciamos sesion
                
                
                
               
            }
            else
            {
                Console.WriteLine("Las contraseñas no coinciden");
                Thread.Sleep(1000);
                Console.WriteLine("Las contraseñas no coinciden");
                Thread.Sleep(1000);
                Environment.Exit(0); // cerrar consola
            }
        }

        public void IniciarSesion()
        {
            string usuario, contraseña;

            Console.WriteLine("-----------INICIAR SESIÓN---------------");
            Console.WriteLine("Ingresa el usuario: ");
            usuario= Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña: ");
            contraseña = Console.ReadLine();
            bool iniciar = usuario == nombreUsuario && contraseña == contraseñaUsuario;

            if (iniciar)
            {
                Console.WriteLine("Inicio exitoso.");
            }
            else
            {
                Console.WriteLine("La contraseña o el usuario estan mal escritos o no existen.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}
