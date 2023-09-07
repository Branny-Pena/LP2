//no se puede hacer un "new Persona"
abstract class Persona{
    private String nombre;
	String apellidoPaterno;
	
    public Persona(){

    }
    
    public Persona(String nombre){
        this.nombre = nombre;
    }
	
	public Persona(String nombre, String apellidoPersona){
		this.nombre = nombre;
		this.apellidoPaterno = apellidoPaterno;
	}
	
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	
	public String getNombre(){
		return nombre;
	}
	
	//abstract es cuando no es necesario definir la implementacion
	abstract public void imprimirDatos();
		//System.out.println("Comportamiento comun");
}

