﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperator.Modelos
{
    [Table("Posicion")]
    public class Posicion
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public List<Operador> Operadores { get; set; }
    }
}
