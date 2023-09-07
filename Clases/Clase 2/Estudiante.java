class Estudiante extends Persona implements IComun{
	@Override
	public void imprimirDatos(){
		//super.imprimirDatos(); //llama la funcion de la clase base
		System.out.println("Comportamiento estudiante");
	}
	
	public void mostrarCodigoPUCP(){
		System.out.println("Codigo PUCP");
	}
}