using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EjercisioIntegrador.Enumeraciones;

namespace EjercisioIntegrador.Entidades
{
    public class Grupo
    {
        private List<Mascota> camada;
        private string nombre;
        private static ETipoManada tipo;

        public ETipoManada Tipo { set => Grupo.tipo = value; }

        static Grupo()
        {
            Grupo.tipo = ETipoManada.UNICA;
        }
        
        private Grupo()
        {
            this.camada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, ETipoManada tipo) : this(nombre)
        {
            Grupo.tipo = tipo;
        }

        /*
          Un Grupo será igual a una Mascota si esta última forma parte de la lista.
 Si una mascota no forma parte de la lista, se podrá agregar con el +. Informar caso contrario.
 Si una mascota forma parte de la lista, se podrá quitar con el -. Informar caso contrario.
 Conversión implícita a String, debiendo quedar la información con el siguiente formato
         */

        public static implicit operator string(Grupo grupoA)
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine($"Grupo: {grupoA.nombre} - tipo: {Grupo.tipo.ToString()}");
            text.AppendLine($"Integrantes: ({grupoA.camada.Count + 1})");
            foreach (Mascota aux in grupoA.camada)
            {
                text.AppendLine(aux.ToString());
            }
            return text.ToString();
        }

        public static bool operator ==(Grupo grupoA, Mascota mascota)
        {

            /*
             foreach (Mascota aux in grupoA.camada)
            {
                if (mascota == aux)
                {
                    return true;
                }
            }

             */
            // Porque tenemos el Equals hecho
            return grupoA.camada.Contains(mascota);
            //return false;
        }

        public static bool operator !=(Grupo grupoA, Mascota mascota)
        {
            return !(grupoA == mascota);
        }

        public static Grupo operator +(Grupo grupoA, Mascota mascota)
        {
            if (!(grupoA == mascota))
            {
                grupoA.camada.Add(mascota);
            }
            else
            {
                Console.WriteLine($"Ya esta '{mascota}' en el grupo");
            }
            return grupoA;
        }

        public static Grupo operator -(Grupo grupoA, Mascota mascota)
        {
            if (grupoA == mascota)
            {
                grupoA.camada.Remove(mascota);
            }
            else
            {
                Console.WriteLine($"No esta '{mascota}' en el grupo");
            }
            return grupoA;
        }
    }
}
