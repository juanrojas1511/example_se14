using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace example_se14
{
    public class Pantallas
        
    {
        public static string[] opcion_trfal = new string[100];
        public static int[] vacunado = new int [100];
        public static float [] edad = new float[100];
        public static int contador = 0;
        
        public static int encuesta_covid()

        {

            Console.WriteLine("============================");

            Console.WriteLine("Encuestas Covid-19");

            Console.WriteLine("============================");

            Console.WriteLine("1: Realizar Encuesta");

            Console.WriteLine("2: Mostrar Datos de la encuesta");

            Console.WriteLine("3: Mostrar Resultados");

            Console.WriteLine("4: Buscar Personas por edad");

            Console.WriteLine("5: Salir");

            Console.WriteLine("============================");

            return Operaciones.getEntero("Ingrese una opción:");

        }

        public static int realizar_encuesta()

        {

            Console.WriteLine("============================");

            Console.WriteLine("Encuesta de vacunación");

            Console.WriteLine("============================");

            float edad_paciente = Operaciones.getDecimal("¿Qué edad tienes?:");
            if (contador == 100)
            {
                Console.WriteLine("No hay edad de 100 años.");
            }
            edad[contador]= edad_paciente;
            
           
            Console.WriteLine("Te has vacunado");

            Console.WriteLine("1: Sí");

            Console.WriteLine("2: No");

            Console.WriteLine("============================");

            int opcionVacunado = 0;
            while (true)
            {
                opcionVacunado = Operaciones.getEntero("Ingrese una opción:");

                if (opcionVacunado == 1 || opcionVacunado == 2)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese 1 o 2.");
                }
            }

            if (opcionVacunado == 1)
            {
                opcion_trfal[contador] = "Sí";
            }
            else 
            {
                opcion_trfal[contador] = "No";
            }

            contador++;
            Console.ReadLine();

            Console.WriteLine("============================");

            Console.WriteLine("Encuesta de vacunación");

            Console.WriteLine("============================");

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("¡ Gracias por participar!");

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("============================");

            Console.WriteLine("1:Regresar");
            
            int opcion = Operaciones.getEntero("Ingresa una opción: ");

            if (opcion == 1) return 0;

            return opcion;

        }

        public static int datos_emcuesta()

        {
            Console.WriteLine("============================");

            Console.WriteLine("Datos de la emcuesta");

            Console.WriteLine("============================");

            Console.WriteLine(" ID | Edad | Vacunado");
            Console.WriteLine("============================");

            string opcionVacunado=opcion_trfal[contador];
            int[] arreglo1 = new int[10000];
            for (int i = 0; i < arreglo1.Length; i++)
            {
                arreglo1[i] = 0000+i;
            }

            for (int i = 0; i < contador; i++)
            {
               
                Console.WriteLine($"{arreglo1[i]}   |\t {edad[i]} |\t{ opcion_trfal[i]}");
            }
            Console.WriteLine("1:Regresar");

            int opcion = Operaciones.getEntero("Ingresa una opción: ");

            if (opcion == 1) return 0;

            return opcion;

        }

        public static int resultados_encuesta()

        {

            Console.WriteLine("============================");

            Console.WriteLine("Resultados de la encuesta");

            Console.WriteLine("============================");
            int personas_sivacunadas = 0;
            int personas_NOvacu = 0;
            int[] edades = new int[6];
            for (int i = 0;i < contador; i++)
            {
                if (opcion_trfal[i] == "Sí")
                {
                    personas_sivacunadas++;
                }
                else
                {
                    personas_NOvacu++;
                }
                if (edad[i]>=1 && edad[i] <= 20)
                {
                    edades[0]++;
                }
                else if (edad[i]>=21 && edad[i] <= 30)
                {
                    edades[1]++;
                }
                else if (edad[i]>=31 && edad[i] <= 40)
                {
                    edades[2]++;
                }
                else if (edad[i]>=41 && edad[i]<=50)
                {
                    edades[3]++;
                }
                else if (edad[i]>=51 && edad[i]<=60)
                {
                    edades[4]++;
                }
                else
                {
                    edades[5]++;
                }
            }
            Console.WriteLine($"{personas_sivacunadas} personas se han vacunado");
            Console.WriteLine($"{personas_NOvacu} personas no se han vacunado");
            Console.WriteLine("");
            Console.WriteLine("Existen:");
            Console.WriteLine($"{edades[0]} personas entre 01 y 20 años");
            Console.WriteLine($"{edades[1]} personas entre 21 y 30 años");
            Console.WriteLine($"{edades[2]} personas entre 31 y 40 años");
            Console.WriteLine($"{edades[3]} personas entre 41 y 50 años");
            Console.WriteLine($"{edades[4]} personas entre 51 y 60 años");
            Console.WriteLine($"{edades[5]} personas de más de 61 años");
            Console.WriteLine("============================");

            Console.WriteLine("1:Regresar");

            int opcion = Operaciones.getEntero("Ingresa una opción: ");

            if (opcion == 1) return 0;

            return opcion;

        }

        public static int buscar_personas()

        {

            Console.WriteLine("=============================");

            Console.WriteLine("Busa a personas por edad");

            Console.WriteLine("=============================");

            float edadBuscada = Operaciones.getDecimal("¿Qué edad quieres buscar?:");
            
            int personas_sivacunadas = 0;
            int personas_NOvacu = 0;

            for (int i = 0; i < contador; i++)
            {
                if (edad[i] == edadBuscada)
                {
           
                    if (opcion_trfal[i] == "Sí")
                    {
                        personas_sivacunadas++;
                    }
                    else
                    {
                        personas_NOvacu++;
                    }
                }
            }
            Console.WriteLine($"{personas_sivacunadas} se vacunaron");
            Console.WriteLine($"{personas_NOvacu} no se vacunaron");

            Console.WriteLine("=============================");

            Console.WriteLine("1:Regresar");

            int opcion = Operaciones.getEntero("Ingresa una opción: ");

            if (opcion == 1) return 0;

            return opcion;

        }

    }
}
