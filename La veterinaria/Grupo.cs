using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace La_veterinaria
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static ETipoManada _tipo;
        static Grupo() => _tipo = ETipoManada.Unica;
        private Grupo() => _manada = new List<Mascota>();
        public Grupo(string nombre) : this() => _nombre = nombre;
        public Grupo(string nombre, ETipoManada tipo) : this(nombre) => _tipo = tipo;
        public static bool operator ==(Grupo grupo, Mascota mascota)
        {
            return grupo._manada.Contains(mascota);
            /*
            foreach (Mascota pet in grupo._manada)
            {
                if(pet == mascota)
                {
                    return true;
                }
            }
            return false;
            */
        }

        public static bool operator !=(Grupo grupo, Mascota mascota)
        {
            return !(grupo == mascota);
        }

        public static Grupo operator +(Grupo grupo, Mascota mascota)
        {
            if (grupo != mascota)
            {
                grupo._manada.Add(mascota);
            }
            else
            {
                Console.WriteLine("La mascota ya se encuentra en la manada");
            }
            return grupo;
        }
        public static Grupo operator -(Grupo grupo, Mascota mascota)
        {
            if (grupo == mascota)
            {
                grupo._manada.Remove(mascota);
            }
            else
            {
                Console.WriteLine("La mascota ya se encuentra en la manada");
            }
            return grupo;
        }

        public ETipoManada Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public static implicit operator string(Grupo grupo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*** MANADA: {grupo._nombre} - " + 
                $"*** TIPO: {grupo.Tipo} - " +
                $"*** INTEGRANTES: {grupo._nombre.Count()} ***");
            foreach (Mascota mascota in grupo._manada)
            {
                sb.AppendLine($"================={mascota.GetType().Name}===================");
                sb.Append(mascota.ToString());
            }
            return sb.ToString();
        }
    }
}
