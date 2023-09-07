class Estudiante : Persona{
    private double CRAEST;

    //se usa base para usar el metodo de la clase padre
    public Estudiante(string nombre, double CRAEST) : base(nombre){
        this.CRAEST = CRAEST;
    }
    public void imprimirDatos(){
        System.Console.WriteLine(Nombre + " " + CRAEST);
    }
}