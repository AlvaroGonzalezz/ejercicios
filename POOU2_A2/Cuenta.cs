using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2_A2
{
    class Cuenta
    {
        #region MiembrosCampos
        // Miembros de tipo Campos
        string numeroCuenta, nombreCliente, primerApellidoCliente, segundoApellidoCliente;
        double saldo;
        DateTime fechaAltaCuenta;
        string calleCliente, coloniaCliente, ciudadCliente, estadoCliente, cpCliente;
        string contactoTelefonicoCliente, contactoMailCliente;
        public string sucursalRegistroCliente;
        #endregion

        #region MiembrosConstructores

        // Constructor vacio o constructor sin parametros
        public Cuenta()
        {
             // Personalizamos la consola
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.White;
            Console.Clear();

            // Inicio de nuestro registro
            Console.WriteLine("----------REGISTRO DE CUENTA DE CLIENTES ----------");
            Console.WriteLine("\nIngresa tu nombre: ");
            this.nombreCliente= Console.ReadLine();
            Console.WriteLine("Ingresa tu primer apellido: ");
            this.primerApellidoCliente= Console.ReadLine();
            Console.WriteLine("Ingresa tu segundo apellido: ");
            this.segundoApellidoCliente= Console.ReadLine();
            Console.WriteLine("Ingresa la calle de tu domicilio: ");
            this.calleCliente= Console.ReadLine();
            Console.WriteLine("Ingresa la colonia de tu domicilio: ");
            this.coloniaCliente= Console.ReadLine();
            Console.WriteLine("Ingresa el código postal de tu domicilio: ");
            this.cpCliente= Console.ReadLine();
            Console.WriteLine("Ingresa la ciudad donde se encuentra tu domicilio: ");
            this.ciudadCliente= Console.ReadLine();
            Console.WriteLine("Ingresa el estado donde se encuentra tu domicilio: ");
            this.estadoCliente= Console.ReadLine();
            Console.WriteLine("Ingresa el número de cuenta: ");
            this.numeroCuenta = Console.ReadLine();
            Console.WriteLine("Ingresa el saldo de tu cuenta: ");
            this.saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa tu contacto teléfonico: ");
            this.contactoTelefonicoCliente = Console.ReadLine();
            Console.WriteLine("Ingresa tu contacto de correo electronico: ");
            this.contactoMailCliente = Console.ReadLine();
            Console.WriteLine("Ingresa la Sucursal de Registro: [San Pedro | Torréon] ");
            this.sucursalRegistroCliente= Console.ReadLine();

            this.fechaAltaCuenta = DateTime.Now; // El .Now nos sirve para calcular la fecha exacta del registro

            
        }

        // Constructor con parametros
        public Cuenta(string numeroCuenta, string nombreCliente, string primerApellidoCliente, string segundoApellidoCliente, DateTime fechaAltaCuenta, string contactoTelefonicoCliente, string sucursalRegistroCliente)
        {
            // Asignar las variables locales a los campos
            this.numeroCuenta = numeroCuenta;
            this.nombreCliente = nombreCliente;
            this.primerApellidoCliente = primerApellidoCliente;
            this.segundoApellidoCliente = segundoApellidoCliente;
            this.fechaAltaCuenta = fechaAltaCuenta;
            this.contactoTelefonicoCliente = contactoTelefonicoCliente;
            this.sucursalRegistroCliente = sucursalRegistroCliente;
        }

        #endregion

        #region MiembrosPropiedades
        // Propiedades
        public string NombreCliente
        {
            get { return nombreCliente; }
        }        
        public string PrimerApellidoCliente
        {
            get { return primerApellidoCliente; }
        }
        public string SegundoApellidoCliente {
            get { return segundoApellidoCliente; }
        }
        public string ContactoMailCliente
        {
            get { return contactoMailCliente; }
            set { contactoMailCliente = value; } 
        }
        #endregion

        #region MiembrosMetodos
        public void MostrarInformacion()
        {
            // Personalizar la consola
            Console.Clear();
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Clear();

            // Inicio de nuestro metodo

            Console.WriteLine("-----INFORMACIÓN DE CUENTA DEL CLIENTE -----");
            Console.WriteLine("Nombre: {0} {1} {2}", nombreCliente, primerApellidoCliente, segundoApellidoCliente);
            Console.WriteLine("Dirección: Calle [{0}], Colonia [{1}], Código Postal [{2}], Ciudad [{3}], Estado [{4}]", calleCliente, coloniaCliente, cpCliente, ciudadCliente, estadoCliente);
            Console.WriteLine("Contacto: Teléfono [{0}], Email [{1}]", contactoTelefonicoCliente, contactoMailCliente);
            Console.WriteLine("Cuenta: Número [{0}], Saldo [{1}]", numeroCuenta, saldo);
            Console.WriteLine("Fecha de Alta: {0}", fechaAltaCuenta);
            Console.WriteLine("Sucursal: {0}", sucursalRegistroCliente);

        }

        #endregion

    }
}
