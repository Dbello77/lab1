using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class persona_atributes : Persona
    {

        bool fumador { get; set; }
        bool bebedor { get; set; }
        bool deportistas { get; set; }
        bool ancianos { get; set; }

        public persona_atributes(string name, string last_name, string sexo, bool fumador, bool bebedor, bool deportista, bool ancianos) : base(name, last_name, sexo)

        {
            this.fumador = fumador;
            this.bebedor = bebedor;
            this.ancianos = ancianos;
            this.deportistas = deportista;
        }

        public void bebedores_ancianos() {
            if (this.bebedor == true && this.ancianos == true) {
                Console.Write($" { this.print_vars()}  soy alchoolico y  fumador \n");
            }
            else if (this.fumador == true && this.bebedor == true && this.ancianos == true)
                {
                    Console.Write($" { this.print_vars()}  soy alchoolico,  fumador y anciano \n");
                }
        }
    }
}