using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace La_veterinaria
{
    public class Perro : Mascota
    {
        private bool _esAlfa;
        private int _edad;

        public static explicit operator int(Perro perro) => perro._edad;
        public static bool operator ==(Perro perro, Perro other) => perro.Nombre == other.Nombre && perro._edad == other._edad && perro.Raza == other.Raza;
        public static bool operator !=(Perro perro, Perro other) => !(perro.Nombre == other.Nombre && perro._edad == other._edad && perro.Raza == other.Raza);
        public override string ToString() => Ficha;

        public override bool Equals(object obj) => obj.GetType() == GetType();
        public override int GetHashCode() => base.Nombre.GetHashCode();

        protected override string Ficha 
        {
            get
            {
                string esAlfa = _esAlfa ? "SI" : "NO";
                StringBuilder sb = new StringBuilder();
                sb.Append(base.DatosCompletos());
                sb.AppendLine($"Alfa de la manada: {esAlfa}");
                sb.AppendLine($"Edad: {_edad}");
                return sb.ToString();
            }
        }

        public Perro(string nombre, string raza, bool alfa, int edad) : base(nombre, raza)
        {
            _edad = edad;
            _esAlfa = alfa;
        }

        public Perro(string nombre, string raza): base(nombre, raza)
        {
            _esAlfa = false;
            _edad = 0;
        }
    }
}
