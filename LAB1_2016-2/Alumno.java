import java.util.Date;

public class Alumno extends MiembroPUCP{
    private double CRAEST;

    public Alumno(double CRAEST, String codigoPUCP, String nombre, String apellidoPaterno, Date fecha,
                String direccion, String email, char sexo){
        super(codigoPUCP, nombre, apellidoPaterno, fecha, direccion, email, sexo);
        this.CRAEST = CRAEST;
    }

    @Override
    public String consultarDatos(){
        String codigo = super.getCodigoPUCP();
        String nombre = super.getNombreCompleto();
        return "Alumno: " + codigo + " - " + nombre  + " - " + CRAEST;
    }
}
