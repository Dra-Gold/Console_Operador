using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperator.Modelos
{
    [Table("Operador")]
    public class Operador
    {
        [Column("Ope_Id")]
        public int Id { get; set; }
        [Column("Ope_Nombre")]
        public String Nombre { get; set; }
        [Column("Ope_Calificacion")]
        public int Id_Calificacion { get; set; } 
        [Column("Ope_Posicion")]
        public int Id_Posicion { get; set; }
        [Column("Ope_Clase")]
        public int Id_Clase { get; set; }

        public List<Caracteristicas_Operador> Caracteristicas_Operador { get; set; }


        [ForeignKey("Id_Calificacion")]
        public Calificacion Calificacion { get; set; }
        [ForeignKey("Id_Posicion")]
        public Posicion Posicion { get; set; }
        [ForeignKey("Id_Clase")]
        public Clase Clase { get; set; }

    }
}
