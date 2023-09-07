class Principal{
    public static void Main(){
        Persona p1 = new Persona("Pedro");
        Estudiante e1 = new Estudiante("Juan", 60.0);
        System.Console.WriteLine("Mi primer programa en C#");
        System.Console.WriteLine(p1.Nombre);
        System.Console.WriteLine(e1.Nombre);
    }
}
