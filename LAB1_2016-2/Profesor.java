import java.util.Date;

public class Profesor extends MiembroPUCP{
    private Dedicacion estado;

    public Profesor(Dedicacion estado, String codigoPUCP, String nombre, String apellidoPaterno, Date fecha,
                String direccion, String email, char sexo){
        super(codigoPUCP, nombre, apellidoPaterno, fecha, direccion, email, sexo);
        this.estado = estado;
    }

    @Override
    public String consultarDatos(){
        return "Profesor: " + super.getCodigoPUCP() + " - " + super.getNombreCompleto() + " - " + estado;
    }
}
