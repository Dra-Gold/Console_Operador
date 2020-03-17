using EntityOperator.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperator.Servicios
{
     public class OperadorServicios
    {
       

        //retorna el operador conetactando las tablas , ademas de usa subtabla
        public Operador GetOperadorByID(int id)
        {
            using (var db = new OperadorContext())
            {
                return db.Operadores.Include(x => x.Calificacion ).Include(x => x.Caracteristicas_Operador.Select(y => y.Caracteristicas)).Include(x => x.Clase).Include(x => x.Posicion).First(x => x.Id == id);
            }
        }

        public List<Operador> GetOperadores()
        {
            using (var db = new OperadorContext())
            {
                return db.Operadores.Include(x => x.Calificacion).Include(x => x.Caracteristicas_Operador.Select(y => y.Caracteristicas)).Include(x => x.Clase).Include(x => x.Posicion).ToList();
            }
        }

    }
}
