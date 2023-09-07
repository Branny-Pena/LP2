using matematicas;
namespace principales{
    public class Principal{
        public static void Main(){
            System.Console.WriteLine("Metodo main");
            Operacion op = new Operacion();
            int a = 10;
            int b = 20;
            System.Console.WriteLine("La suma de " + a + " + " + b +  
                                    " es: " + op.sumar(a, b));
        }
    }
}