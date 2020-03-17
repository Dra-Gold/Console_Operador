using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperator.Modelos
{
    [Table("Caracteristicas")]
    public class Caracteristicas
    {

        public int Id { get; set; }
        public String Nombre { get; set; }
        public List<Caracteristicas_Operador> Caracteristicas_Operador { get; set; }

    }
}
