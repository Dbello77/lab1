using System;
using System.ComponentModel.Design;

public struct persona_vars
{
    public persona_atributes persona_instance { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        int x = 0, numero = 0;
        bool exit = true;
        Console.WriteLine("Defina la cantidad de personas que desea procesar");
        string input = Console.ReadLine();
        while (exit)
        {
            try
            {
                numero = int.Parse(input);
                Console.WriteLine($"Número ingresado: {numero}");
                x = numero;
                exit = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor ingresado no es un número válido.");
                input = Console.ReadLine(); // Solicitar nuevamente la entrada
            }
        }

        string nombre, apellido, options;
        char sexo = ' '; // Inicializar sexo con un espacio en blanco
        bool fumador = false, bebedor = false, deportista = false, anciano = false;
        ////////////////////////////////////////////////////////////////////////////////////////////
        persona_vars[] personas = new persona_vars[x];

        for (int i = 0; i < x; i++)
        {
            bebedor = false; fumador = false; deportista = false; anciano = false;
            Console.WriteLine("Digite un nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite el apellido: ");
            apellido = Console.ReadLine();
            /////////////////////////
            personas[i] = new persona_vars
            {
                persona_instance = new persona_atributes(nombre, apellido, sexo, fumador, bebedor, deportista, anciano)
            };
        


            exit = true;
            while (exit)
            {
                Console.WriteLine("Digite el sexo de la persona ('M' o 'F'): ");
                string entrada = Console.ReadLine();
                if (entrada.Length == 1 && (entrada[0] == 'F' || entrada[0] == 'f' || entrada[0] == 'M' || entrada[0] == 'm'))
                {
                    sexo = entrada[0];
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese 'F' o 'M' (mayúscula o minúscula): ");
                }
            }

            Console.WriteLine("Selecciona todas las opciones que apliquen para su definición: \n" +
                "Condición de la persona: \n" +
                "1: Fumador. \n" +
                "2: Bebedor. \n" +
                "3: Deportista. \n" +
                "4: Anciano. \n" +
                "Nota: separa opciones usando comas");
            options = Console.ReadLine();


            //  PRIMER MENU  DE 4 OPCIONES 
            foreach (var letter in options)
            {
                switch (letter)
                {
                    case '1':
                        fumador = true;
                        break;
                    case '2':
                        bebedor = true;
                        break;
                    case '3':
                        deportista = true;
                        break;
                    case '4':
                        anciano = true;
                        break;
                    case ',':
                    case '.':
                        // Ignorar comas y puntos
                        break;
                    default:
                        Console.Write($"Entrada no válida: {letter}");
                        break;
                }
            }
            personas[i] = new persona_vars
            {
                persona_instance = new persona_atributes(nombre, apellido, sexo, fumador, bebedor, deportista, anciano)
            };
        }

        exit= false;

        while (!exit) {
            try
            {
                menu();
                Console.WriteLine($"Número ingresado: {numero}");
                input = Console.ReadLine();
                numero = int.Parse(input);
                if (numero == 7)
                {
                    Console.WriteLine("Usted a seleccionado salir del programa \n presione cualquier tecla para continuar");
                    Console.ReadKey();
                    exit = true;
                }
                else if (numero > 0 && numero < 7)
                {

                    foreach (var item in personas)
                    {

                        item.persona_instance.bebedores_ancianos(numero);
                    }

                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                }
                else {
                    Console.Write("La opcion entrada es invalida");
                    Console.ReadKey();
                }
            }
            catch {

                Console.WriteLine("El valor ingresado no es un número válido.");
                Console.ReadKey();

            }
        }

    }



    public static void  menu() {
        Console.Clear();
        Console.WriteLine("Elija una opcion: \n 1.\tBebedores y ancianos. \n 2.\tFumadores y hombres. " +
            "\n 3. \tAncianos y deportistas. \n 4. \tBebedor y fumador de sexo femenino.\n 5. \tAncianos de sexo femenino y no deportistas." +
            " \n 6. \tVer si todo bebedor es fumador.\n 7. \tSalir");
    }
}
