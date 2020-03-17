using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperator.Modelos
{
    public  class OperadorContext : DbContext
    {
        public OperadorContext() : base("OpeConnectionString")
        {
            Database.SetInitializer<OperadorContext>(null);
        }

        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Operador> Operadores { get; set; }
    }
}
