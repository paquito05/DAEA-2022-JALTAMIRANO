using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static dynamic Operaciones(double a, double b, String operacion)
        {



            double resultado = 0;

            switch (operacion)
            {
                case "S":

                    resultado = a + b;
                    return "La Suma de " + a + " y " + b + " es " + resultado;
                    break;

                case "R":
                    resultado = a - b;
                    return "La Resta de " + a + " y " + b + " es " + resultado;
                    break;

                case "M":
                    resultado = a * b;

                    return "La Multiplicación de " + a + " y " + b + " es " + resultado;
                    break;

                case "D":
                    if (b == 0)
                    {
                        return "No se puede Dividir entre 0";
                        break;
                    }
                    resultado = (a / b);
                    return "La Divicion de " + a + " y " + b + " es " + resultado;
                    break;

                default:
                    return "Operacion incorrecta";
                    break;
            }

            return resultado;
        }


        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es :{1}", i, Math.Sqrt(i));
            }
        }


        static void numeroPrimos(int cantidad)
        {

            //variable que contiene el numero que se está probando
            int n = 2;
            //variable que contiene el total de numeros primos encontrados
            int total = 1;

            //iterar mientras el total de numeros primos no se mayor a 100
            while (total <= cantidad)
            {

                //variable que indica si un numero es primo o no
                bool esPrimo = true;

                //se divide el numero (n) entre todos los numeros anterios a el
                //si el modulo de la division es 0 significa que el numero no es primo
                //y se marca la variable esPrimo = false y se termina el ciclo for
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                //si despues de ejecutar el ciclo for la variable esPrimo sigue
                //teniendo un valor true entonces se imprime el numero y se incrementa
                // el contador de numeros encontrados total++
                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                //se incrementa para evaluar el siguiente número
                n++;
            }
        }



        static String farenheit_a_Celsius(double gradosF) {

            double celsius = ( 5 * (gradosF - 32) / 9);

            string mensaje = gradosF + " farenheit es igual a "+ celsius + "° celsius";

            return mensaje;
        }

        static String Celsius_a_farenheit(double gradosC)
        {

            double farenheit = ((9*gradosC)/5) + 32;

            string mensaje = gradosC + " Celsius es igual a " + farenheit + "° celsius";
            return mensaje;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Operaciones Basicas");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Imprimir los 10 primeros numero primos");
                Console.WriteLine("[4] Conversion de temperatura F° a C°");
                Console.WriteLine("[5] Conversion de temperatura C° a F°");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("[S] Suma");
                        Console.WriteLine("[R] Resta");
                        Console.WriteLine("[M] Multiplicaion");
                        Console.WriteLine("[D] Divicion");
                        String operacion = Console.ReadLine();
                        Console.WriteLine("Ingrese el primer número");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo número");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(Operaciones(a, b, operacion));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        numeroPrimos(10);
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese los grado en Farenheit para covertir a Celsius");
                        double gradosF = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(farenheit_a_Celsius(gradosF));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese los grado en Celsius para covertir a Farenheit");
                        double gradosC = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Celsius_a_farenheit(gradosC));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
        /*
        static void Main(string[] args)
        {
         Console.WriteLine("Programa lab 01");
         Raiz();
         Console.ReadKey();
         Console.ReadKey();
         }
        */
    }
}