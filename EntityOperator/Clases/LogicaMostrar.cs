using EntityOperator.Modelos;
using EntityOperator.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperator.Clases
{
    public class LogicaMostrar
    {
       private  OperadorServicios _opeSer = new OperadorServicios();

        public  void MostraOperadores()
        {
            var model = _opeSer.GetOperadores();

            foreach (Operador ope in model)
            {
                Recorre(ope);

            }
        }

        public void MostrarOperador(int id)
        {
            var model = _opeSer.GetOperadorByID(id);
            Recorre(model);

        }


        public void Recorre(Operador ope)
        {
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine($"|{"Nombre"}{ope.Nombre,39} |");
            Console.WriteLine($"|{"Calificacion"}{ope.Calificacion.Nombre,33} |");
            Console.WriteLine($"|{"Clase"}{ope.Clase.Nombre,40} |");
            Console.WriteLine($"|{"Posicion"}{ope.Posicion.Nombre,37} |");
            foreach (Caracteristicas_Operador cara in ope.Caracteristicas_Operador)
            {
                Console.WriteLine($"|{"Caracteristicas"}{cara.Caracteristicas.Nombre,30} |");
            }
            Console.WriteLine("|----------------------------------------------|");
        }

    }
}
