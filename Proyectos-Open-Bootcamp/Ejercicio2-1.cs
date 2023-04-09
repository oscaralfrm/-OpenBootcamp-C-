using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos_Open_Bootcamp
{
    internal class Ejercicio2_1
    {
        public static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int edad;
            string preguntaPrograma;
            Boolean sabeProgramar;
            string respuestaProgramar;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Ud. sabe programar?");
            preguntaPrograma = Console.ReadLine();

            if (preguntaPrograma.ToLower() == "si")
            {
                sabeProgramar = true;
                respuestaProgramar = "ud. sabe programar";
            }
            else
            {
                sabeProgramar = false;
                respuestaProgramar = "ud. NO programar";
            }
            Console.WriteLine($"Bienvenidx al Sistema {nombre + " " + apellido}.");
            Console.Write($"Tu edad es de: {edad} años, y {respuestaProgramar} ({sabeProgramar}).");

            // Subpunto 2

            Coche auto = new Coche(4, 4, "Mitsubishi", true);
            Console.WriteLine(auto.ToString());

            Mesa mesita = new Mesa(80, 5, "Granito", "Rojo");
            Console.WriteLine(mesita.ToString());

            // Subpunto 3
            Console.WriteLine("Ingrese un número: ");
            int numeroAComparar = Convert.ToInt32(Console.ReadLine());
            if (numeroAComparar >= 18)
            {
                Console.WriteLine("El número que ud. ingresó es mayor o igual a 18.");
            }
            else
            {
                Console.WriteLine("El número que ud. ingresó es menor a 18.");
            }

            char caracter;
            Console.WriteLine("Ingrese un carácter: ");
            caracter = Convert.ToChar(Console.ReadLine());
            if (caracter == 'a')
            {
                Console.WriteLine("Ud. ingresó el caracter \'a\'");
            }
            else
            {
                Console.WriteLine("Ud. ingresó un CARÁCTER DIFERENTE a \'a\'");
            }

            if (caracter == 'a' && numeroAComparar >= 18) {
                Console.WriteLine("Ambas condiciones se cumplieron.");
            }
            else
            {
                Console.WriteLine("Al menos alguna de las dos condiciones NO se cumplieron.");
            }

            if (caracter == 'a' || numeroAComparar >= 18)
            {
                Console.WriteLine("Al menos alguna de las dos condiciones SE CUMPLIÓ.");
            }
            else
            {
                Console.WriteLine("NO SE CUMPLIÓ NINGUNA DE LAS CONDICIONES.");
            }

        }
    }
    internal class Coche
    {
        private int puertas;
        private int ruedas;
        private string marca;
        private bool ITVVigente;

        public Coche(int puertas, int ruedas, string marca, bool ITVVigente)
        {
            this.puertas = puertas;
            this.ruedas = ruedas;
            this.marca = marca;
            this.ITVVigente = ITVVigente;
        }

        // Getters and Setters - Coche

        public int Puertas
        {
            get { return puertas; }
            set { puertas = value;  }
        }

        public int Ruedas
        {
            get { return ruedas; }
            set { ruedas = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public bool ITVIigente
        {
            get { return ITVVigente; }
            set { ITVVigente = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ": Puertas: " + puertas.ToString() + " ; Ruedas: " + 
                ruedas.ToString() + " ; Marca: " + marca + " ; ITVVigente: " + ITVVigente.ToString();
        }

    }

    internal class Mesa
    {
        private long peso;
        private long largo;
        private string material;
        private string color;

        public Mesa(long peso, long largo, string material, string color)
        {
            this.peso = peso;
            this.largo = largo;
            this.material = material;
            this.color = color;
        }

        // Getters and Setters - Mesa

        public int Peso
        {
            get { return Convert.ToInt32(peso); }
            set { peso = value; }
        }

        public int Largo
        {
            get { return Convert.ToInt32(largo); }
            set { largo = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ": Peso: " + peso.ToString() + " ; Largo: " +
                largo.ToString() + " ; Material: " + material + " ; Color: " + color.ToString();
        }
    }
}
