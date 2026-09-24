using System.Collections.Generic;
using System.Linq;

namespace SolucionCapas.Datos
{
    public class PersonaDatos
    {

        private List<(string Dni, string Nombre)> _tablaPersonas = new List<(string, string)>
        {
            ("98253332", "Pablo"),
            ("78247691", "Carlos")
        };

        public (string Dni, string Nombre)? BuscarPorDni(string dni)
        {
            var resultado = _tablaPersonas.FirstOrDefault(p => p.Dni == dni);
            if (resultado.Dni == null) return null;
            return resultado;
        }
    }
}
