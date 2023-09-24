using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    

    struct persona_vars
    {
        public persona_atributes persona_instance { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int x=0,numero=0;
            bool exit=true;
            Console.WriteLine(" Defina la cantidad de personas q desea procesar");
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
                    
                }
            }
            
           
            
            string nombre, apellido, sexo,options;
            bool fumador =false, bebedor=false, deportista=false, anciano=false;
            persona_vars[] personas = new persona_vars[x];

            for (int i = 0; i < x; i++)
            {
                bebedor = false; fumador = false; deportista = false;anciano = false;
                Console.WriteLine("Digite un nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Digite el apellido: ");
                apellido = Console.ReadLine();
                Console.WriteLine("Digite el sexo de la persona: ");
                sexo = Console.ReadLine();
                Console.WriteLine("Select all options that apply: \n" +
                    "Person conditions: \n"+
                    "1: Fumador. \n"+
                    "2: bebedor.\n "+
                    "3: Deportisa. \n"+
                    "4: Anciano. \n"+
                    "Nota: separa usando comas");
                options = Console.ReadLine();
                foreach (var letter in options) {

                    switch (letter) {

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
                            // Ignore commas and dots
                            break;
                        default:
                            Console.Write($" invalid input detected {letter}");
                            break;
                    }
                
                }
                personas[i] = new persona_vars
                {
                            
                    persona_instance = new persona_atributes(nombre, apellido, sexo,fumador,bebedor,deportista,anciano)
                };
            }
            // personas[0].persona_instance.Name = "ss";
            foreach (var item in personas)
            {
                item.persona_instance.bebedores_ancianos();
                
            }
            Console.ReadKey();
        }
    }
}

