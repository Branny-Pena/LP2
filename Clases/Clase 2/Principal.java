/*
Ambitos que se pueden usar
-public
-private
-protected
-default -> ambito por defecto, en caso no se declare otro ambito, la calse tiene
			visibilidad dentro del mismo paquete
*/

class Principal{
	public static void main(String[] args){
		//Persona p1 = new Persona();
		Estudiante e1 = new Estudiante();
		Docente d1 = new Docente();
		e1.setNombre("Juan");
		String nombre = e1.getNombre();
		//System.out.println(p1.getNombre());
		e1.imprimirDatos();
		d1.imprimirDatos();
		e1.mostrarCodigoPUCP();
	}
}
