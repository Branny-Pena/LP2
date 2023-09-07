public class Estudiante extends MiembroPUCP{
    private boolean matriculado;

    public Estudiante(String codigoPUCP, String nombre, String apellidoPaterno, boolean matriculado){
        super(codigoPUCP, nombre, apellidoPaterno);
        this.matriculado = matriculado;
    }

    @Override
    public String consultarDatos(){
        String datos = "Estudiante: ";
        datos += super.consultarDatos() + " - Matriculado(a): " + matriculado + "\n";
        return datos;
    }
}
