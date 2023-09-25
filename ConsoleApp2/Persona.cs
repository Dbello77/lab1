public class Persona
{
    private string Nombre { get; set; }
    private string Apellido { get; set; }
    private char Sexo { get; set; } // vista en clases 

    public Persona(string nombre, string apellido, char sexo)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Sexo = sexo;
    }

    public string ObtenerNombreCompleto()
    {
        return $"{this.Nombre} {this.Apellido}";
    }

    public string ObtenerGenero()
    { 
        
        return (this.Sexo == 'M' || this.Sexo == 'm') ? "M" : "F";

        /*
        if (this.Sexo == 'M' || this.Sexo == 'm')
        {
            return "M";
        }
        else if (this.Sexo == 'F' || this.Sexo == 'f')
        {
            return "F";
        }
        else
        {
            return "Sexo no especificado; seleccione 'F' o 'M'.";
        }
        */
    }
   


    
}
