using System;

namespace EjercisioIntegrador.Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }

        protected virtual string DatosCompletos()
        {
            return $"{nombre} - {raza}";
        }

        protected abstract string Ficha();

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public static bool operator ==(Mascota mascotaA, Mascota mascotaB)
        {
            return mascotaA.nombre == mascotaB.nombre && mascotaA.raza == mascotaB.raza;
        }
        public static bool operator !=(Mascota mascotaA, Mascota mascotaB)
        {
            return !(mascotaA == mascotaB);
        }
    }
}
