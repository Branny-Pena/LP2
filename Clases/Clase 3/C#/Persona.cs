class Persona{
    private string nombre;

    public Persona(string nombre){
        this.nombre = nombre;
    }
    //propiedad del atributo, get y set del atributo
    public string Nombre{
        get{
            return nombre;
        }
        set{
            this.nombre = value;
        }
    }
    
}