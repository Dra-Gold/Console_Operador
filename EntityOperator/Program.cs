using EntityOperator.Clases;
using EntityOperator.Modelos;
using EntityOperator.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperator
{
    class Program
    {

        static void Main(string[] args)
        {
            int respuesta = 0;

            do
            {
                Console.WriteLine("|----------------------------------------------|");
                Console.WriteLine("|Por Favor Eliga Una de las siguientes Opciones|");
                Console.WriteLine("|----------------------------------------------|");
                Console.WriteLine($"|{"1.-Mostrar Todos Los Operadores"}{"",14} |");
                Console.WriteLine($"|{"2.-Buscar Operador por Id"}{"",20} |");
                Console.WriteLine($"|{"3.-Presiones para salir"}{"",22} |");
                respuesta = Convert.ToInt32(Console.ReadLine());
                LogicaMostrar logica = new LogicaMostrar();

                switch (respuesta)
                {
                    case 1:
                        logica.MostraOperadores();
                        break;
                    case 2:
                        Console.WriteLine($"|{"Escriba Id a Buscar"}{"",26} |");
                        int id = Convert.ToInt32(Console.ReadLine());
                        logica.MostrarOperador(id);
                        break;
                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                }
            } while (respuesta != 3);

            Console.ReadKey();
        }
    }
}
