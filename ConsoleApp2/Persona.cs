using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Persona
    {
        private string Name { get; set; }
        private string Last_name { get; set; }
        private string Sexo { get; set; }

        public Persona(string name, string last_name, string sexo)
        {
            this.Name = name;
            this.Last_name = last_name;
            this.Sexo = sexo;

        }

        public string print_vars()
        {

            return ($"Mi name is {this.Name} {this.Last_name}, my gender is {this.Sexo} ");
        }
    }
 }
