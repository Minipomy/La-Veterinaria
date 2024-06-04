using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_veterinaria
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        { }
        public static bool operator ==(Gato gato, Gato other) => gato.Nombre == other.Nombre && gato.Raza == other.Raza;
        public static bool operator !=(Gato gato, Gato other) => !(gato.Nombre == other.Nombre && gato.Raza == other.Raza);
        public override string ToString() => Ficha;
        public override bool Equals(object obj) => obj.GetType() is Gato;
        protected override string Ficha
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(base.DatosCompletos());
                return sb.ToString();
            }
        }
    }
}
