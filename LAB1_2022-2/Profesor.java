public class Profesor extends MiembroPUCP{
    private Categoria categoria;

    public Profesor(String codigo, String nombre, String apellidoPaterno, Categoria categoria){
        super(codigo, nombre, apellidoPaterno);
        this.categoria = categoria;
    }

    @Override
    public String consultarDatos(){
        String datos = "Profesor(a): ";
        datos += super.consultarDatos() + " - " + categoria + "\n";
        return datos;
    }
}
