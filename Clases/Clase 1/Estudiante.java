//
/*
*/
class Estudiante{
	//propiedades
	String codigo;
	String nombre;
	String apellidoPaterno;
	double CRAEST;
	
	//constructos
	public Estudiante(){
		
	}
	
	public Estudiante (String nombre, String apellidoPaterno){
		this.nombre = nombre;
		this.apellidoPaterno = apellidoPaterno;
	}
	
	//metodos (funciones y procedimientos)
	public static void main(String[] args){
		//declaracion de una variable (es un puntero)
		Estudiante est1;
		//reservar espacio de memoria para el objeto
		//inicializar la variable
		est1 = new Estudiante();
		//asignamos un nombre
		est1.nombre = "Juan";
		//asignamos un apellido
		est1.apellidoPaterno = "Perez";
		//imprimimos nombre completo
		est1.imprimirNombreCompleto();
		
		//declarar e inicializar un estudiante
		Estudiante est2 = new Estudiante("Pedro", "Sifuentes");
		//imprimir nombre completo
		est2.imprimirNombreCompleto();
	}
	
	void imprimirNombreCompleto(){
		System.out.println(nombre + " " + apellidoPaterno);
	}
}

/*.java -> compilacion -> .class [bytecode]
 .class -> interpretacion (java -> jre) -> salidas */