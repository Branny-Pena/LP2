public class Egresado extends MiembroPUCP{
    private boolean titulado;

    public Egresado(String codigoPUCP, String nombre, String apellidoPaterno, boolean titulado){
        super(codigoPUCP, nombre, apellidoPaterno);
        this.titulado = titulado;
    }

    @Override
    public String consultarDatos(){
        String datos = "Egresado(a): ";
        datos += super.consultarDatos() + " - Titulado(a): " + titulado + "\n";
        return datos;
    }
}
