using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_veterinaria
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;
        public string Raza { get => _raza; }
        public string Nombre { get => _nombre; }
        protected abstract string Ficha {  get; }
        public Mascota(string nombre, string raza)
        {
            _nombre = nombre;
            _raza = raza;
        }
        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {Nombre}");
            sb.AppendLine($"RAZA: {Raza}");
            return sb.ToString();
        }

    }
}
