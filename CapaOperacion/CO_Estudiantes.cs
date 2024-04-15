using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaOperacion
{
    public class CO_Estudiantes
    {
        private CD_Estudiantes objcd_estudiantes = new CD_Estudiantes();

        public List<Estudiantes> listar()
        {
            return objcd_estudiantes.listar();
        }
    }
}
