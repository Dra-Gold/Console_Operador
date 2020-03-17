using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperator.Modelos
{
    [Table("Caracteristicas_Operador")]
    public class Caracteristicas_Operador
    {
        public int Id { get; set; }
        public int Id_Operador { get; set; }
        public int Id_Caracteristicas { get; set; }
        [ForeignKey("Id_Operador")]
        public Operador Operador { get; set; }
        [ForeignKey("Id_Caracteristicas")]
        public Caracteristicas Caracteristicas { get; set; }
    }
}
