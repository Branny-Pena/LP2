import java.util.Date;

public class Persona extends Artista{
	private String nombre;
	private String apellido;
	private Date fechaNacimiento;
	private char sexo;
	
	public Persona(String nombreArtistico, OrigenArtista origen, String nombre,
				String apellido, Date fechaNacimiento, char sexo){
		super(nombreArtistico, origen);
		this.nombre = nombre;
		this.apellido = apellido;
		this.fechaNacimiento = fechaNacimiento;
		this.sexo = sexo;
	}
	
	@Override
	public String consultarDatos(){
		return "PERSONA: " + super.getNombre() + " - " + super.getOrigen() + "\n";
	}
}