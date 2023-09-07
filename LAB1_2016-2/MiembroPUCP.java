import java.util.Date;

abstract public class MiembroPUCP extends Miembro{
    private String codigoPUCP;

    public MiembroPUCP(String codigoPUCP, String nombre, String apellidoPaterno, Date fecha,
                String direccion, String email, char sexo){
        super(nombre, apellidoPaterno, fecha, direccion, email, sexo);
        this.codigoPUCP = codigoPUCP;
    }

    public String getCodigoPUCP(){
        return codigoPUCP;
    }

    public String getNombreCompleto(){
        return super.getNombre() + " " + super.getApellidoPaterno();
    }

    public abstract String consultarDatos();
}
