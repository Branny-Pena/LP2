import java.util.Date;

abstract public class Miembro{
    private static int correlativo = 1;
    private int codigo;
    private String nombre;
    private String apellidoPaterno;
    private Date fechaNacimiento;
    private String direccion;
    private String email;
    private char sexo;

    public Miembro(){
        this.codigo = correlativo;
        correlativo++;
    }

    public Miembro(String nombre, String apellidoPaterno, Date fecha, String direccion, String email,
                char sexo){
        this.codigo = correlativo;
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
        this.direccion = direccion;
        this.fechaNacimiento = fecha;
        this.email = email;
        this.sexo = sexo;
        correlativo++;
    }

    public String getNombre(){
        return nombre;
    }

    public String getApellidoPaterno(){
        return apellidoPaterno;
    }
}
