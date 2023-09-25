using System;

public class persona_atributes : Persona
{
    private bool fumador { get; set; }
    private bool bebedor { get; set; }
    private bool deportistas { get; set; }
    private bool ancianos { get; set; }


    public persona_atributes(string name, string last_name, char sexo, bool fumador, bool bebedor, bool deportista, bool ancianos)
        : base(name, last_name, sexo) // Pasar nombre y apellido a la clase base
    {
        this.fumador = fumador;
        this.bebedor = bebedor;
        this.ancianos = ancianos;
        this.deportistas = deportista;

    }
    // MENU 2
    public void bebedores_ancianos(int opcion) //DENTRO DEL MENU 2, SOLO VA IMPRIMIR LAS OPCIONES QUE MARCO DEL MENU 1 
     {
        switch (opcion) {
            case 1:
                if(this.ancianos && this.bebedor)
                    Console.WriteLine($" {this.ObtenerNombreCompleto()}");
                break;
            case 2:
                if(this.fumador && this.ObtenerGenero() =="M")
                    Console.WriteLine($" {this.ObtenerNombreCompleto()}");

                break;
            case 3:
                if(this.ancianos && this.deportistas  )
                    Console.WriteLine($" {this.ObtenerNombreCompleto()}");
                break;

            case 4:
                if(this.fumador && this.bebedor && this.ObtenerGenero() == "F")
                    Console.WriteLine($" {this.ObtenerNombreCompleto()}");
                break;
            case 5:
                if (this.ObtenerGenero() == "F" && !this.deportistas)
                    Console.WriteLine($" {this.ObtenerNombreCompleto()}");
                break;
            case 6:
                if( this.fumador && this.bebedor)
                    Console.WriteLine($" {this.ObtenerNombreCompleto()}");
                break;
        }


      }
        
    

    
}
