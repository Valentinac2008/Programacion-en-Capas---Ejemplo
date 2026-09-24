using System.Collections.Generic;
using System.Linq;

namespace SolucionCapas.Datos
{
    public class PersonaDatos
    {
        // Simulamos la BD con una lista de datos
        private List<(string Dni, string Nombre)> _tablaPersonas = new List<(string, string)>
        {
            ("23269431", "Alberto"),
            ("27576691", "Noemi")
        };

        // Devuelve una lista con los datos o null
        public (string Dni, string Nombre)? BuscarPorDni(string dni)
        {
            var resultado = _tablaPersonas.FirstOrDefault(p => p.Dni == dni);
            if (resultado.Dni == null) return null;
            return resultado;
        }
    }
}
