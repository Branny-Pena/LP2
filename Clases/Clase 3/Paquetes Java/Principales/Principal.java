package Principales;
import Matematicas.Operacion;

public class Principal{    
    public static void main(String[] args) {
        Operacion op1 = new Operacion();
        int a = 10;
        int b = 20;
        System.out.println("La suma de " + a + " + " + b + " es: " + op1.sumar(a, b));
    }
}
