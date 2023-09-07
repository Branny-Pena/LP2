abstract class MiembroPUCP implements IConsultable{
    private String nombre;
    private String apellidoPaterno;
    private String codigoPUCP;

    public MiembroPUCP(String codigoPUCP, String nombre, String apellidoPaterno){
        this.codigoPUCP = codigoPUCP;
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
    }

    public String consultarDatos(){
        return codigoPUCP + " - " + nombre + " " + apellidoPaterno;
    }
}