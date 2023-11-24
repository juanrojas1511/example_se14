using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_se14
{
    internal class Program

    {

        static void Main(string[] args)

        {

            int opcion = Pantallas.encuesta_covid();

            do

            {

                Console.Clear();

                switch (opcion)

                {

                    case 1:

                        opcion = Pantallas.realizar_encuesta();

                        break;

                    case 2:

                        opcion = Pantallas.datos_emcuesta();

                        break;

                    case 3:

                        opcion = Pantallas.resultados_encuesta();

                        break;

                    case 4:

                        opcion = Pantallas.buscar_personas();

                        break;



                    case 0:

                    default:

                        opcion = Pantallas.encuesta_covid();

                        break;

                }

            } while (opcion != 5);

        }

    }
}
