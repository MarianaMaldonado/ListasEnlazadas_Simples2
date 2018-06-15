using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas_Simples
{
    class Agenda
    {
        Contacto inicio, ultimo, anterior, temporal, posicion_encontrada, position, buscado;

        public Agenda()
        {
             inicio = null;  
        }

        public void Agregar(Contacto nuevo)
        { 

            if(inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
            }
            else 
            {
                nuevo.anterior = ultimo;
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        public void agregarInicio(Contacto primerP)
        {
            if (inicio == null)
            {
                inicio = primerP;
                ultimo = primerP;
            
            }
            else
            {
                primerP.siguiente = inicio;
                inicio = primerP;
            }
        }

        public void Insertar(Contacto nuevo, int position)
        {
            int i = 1;
            temporal = inicio;

            while(i < position-1)
            {
                temporal = temporal.siguiente;
                i++;
            }

            nuevo.siguiente = temporal.siguiente;
            temporal.siguiente = nuevo;
        }

        public Contacto Buscar(int telefono)
        {
            temporal = inicio;
            buscado = null;
            
            while(buscado == null && temporal != null )
            {
                if (telefono == temporal.Telefono)
                {
                    buscado = temporal;
                    //return temporal.ToString();
                }
                else
                    anterior = temporal;
                    temporal = temporal.siguiente;
            }

            return buscado;
        }

        public bool Eliminar(int telefono)
        {

            if (Buscar(telefono) != null)
            {
                if (buscado == inicio)
                {
                    inicio = inicio.siguiente;
                }

                else
                    anterior.siguiente = buscado.siguiente;

                return true;

            }
            return false;
            
        }

        public bool EliminarPrimero()
        {
            if (inicio == null)
            {
                return false;
            }
            else

            if(inicio != null)
            {
                inicio = inicio.siguiente;
            }

            return true;
        }

        public string Listar()
        {
            string contacto = "";
            temporal = inicio;

            while (temporal != null)
            {
                contacto += temporal.ToString() + Environment.NewLine;
                temporal = temporal.siguiente;
            }

            return contacto;
        }

    }
}
