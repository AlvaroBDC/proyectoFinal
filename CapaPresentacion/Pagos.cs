﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pagos
    {
        public int ID { get; set; }
        public Estudiantes oEstudiantes { get; set; }
        public string TipoPago { get; set; }
        public decimal Monto { get; set; }
        public string Fecha { get; set; }
    }
}
