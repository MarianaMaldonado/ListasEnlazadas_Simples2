using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas_Simples
{
    class Contacto
    {
        /// <summary>
        /// Agenda con listas simples
        /// </summary>
        private string _nombre; // { get; set; }
        private int _telefono; // { get; set; }
        private string _email; // { get; set; }
        private string _edad; // { get; set; }
        private Int32 _codigo; // { get; set; }
        public Contacto siguiente { get; set; }
        public Contacto anterior { get; set; }

        /// <summary>
        /// Propiedad de nombre del contacto
        /// </summary>
        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        /// <summary>
        /// Propiedad de la edad del contacto
        /// </summary>
        public string Edad
        {
            get
            {
                return _edad;
            }

            set
            {
                _edad = value;
            }
        }

        /// <summary>
        // Propiedad del correo del contacto
        // </summary>
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }


        /// <summary>
        /// Propiedad de teléfono del contacto 
        /// </summary>
        public int Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }


        /// <summary>
        /// Propiedad del codigo del contacto
        /// </summary>
        public Int32 Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public Contacto(string Nombre, int Telefono, string Email, string Edad, Int32 Codigo)
        {
            _nombre = Nombre;
            _telefono = Telefono;
            _email = Email;
            _edad = Edad;
            _codigo = Codigo;

            anterior = null;

        }

        public override string ToString()
        {
            string Contacto = "Nombre: " + Nombre.ToString() + Environment.NewLine +
                              "Teléfono: " + Telefono.ToString() + Environment.NewLine +
                              "Email: " + Email.ToString() + Environment.NewLine +
                              "Edad: " + Edad.ToString() + Environment.NewLine +
                              "Codigo: " + Codigo.ToString() + Environment.NewLine;

            return Contacto;
        }

    }
}
