using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Proyectos_Open_Bootcamp
{
     public class Ejercicio1_1
    {
        public static TimeSpan hora_actual = DateTime.Now.TimeOfDay;

        public static void Main(string[] args)
        {
            string hora = hora_actual.Hours.ToString();
            string minutos = hora_actual.Minutes.ToString();
            string segundos = hora_actual.Seconds.ToString();
            string am_pm;
            if (Int16.Parse(hora) >= 12)
            {
                am_pm = "(PM)";
            }
            else
            {
                am_pm = "(AM)";
            }
            string horaDelDia = hora + ":" + minutos + ":" + segundos + " " + am_pm;
            Console.WriteLine("Ingrese su nombre, por favor: ");
            string nombre_usuario = Console.ReadLine();
            if (nombre_usuario != null)
            {
                Console.WriteLine($"¡Buenos días {nombre_usuario}!");
            }
            Console.WriteLine($"La hora actual es: {horaDelDia}");
        }
    }
}
