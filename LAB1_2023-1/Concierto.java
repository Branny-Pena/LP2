import java.util.ArrayList;

public class Concierto extends Evento{
	private boolean acustico;
	private boolean tecnologiaAsistiva;
	private ArrayList<Funcion> funciones;
	
	public Concierto(String nombre, double costoRealizacion, 
				boolean benefico, boolean acustico, 
				boolean tecnologiaAsistiva){
		super(nombre, costoRealizacion, benefico);
		this.acustico = acustico;
		this.tecnologiaAsistiva = tecnologiaAsistiva;
	}
	
	@Override
	public String consultarDatos(){
		String datos = "CONCIERTO: " + super.getNombre() + " - ACUSTICO: " + 
				acustico + " - TEC ASISTIVA: " + tecnologiaAsistiva + "\n";
		datos += super.consultarDatosArtistasyFuncionesEvento();
		return datos;
	}
}