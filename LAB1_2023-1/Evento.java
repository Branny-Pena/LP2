import java.util.ArrayList;
import java.text.SimpleDateFormat;

abstract public class Evento implements IConsultable{
	private static int correlativo = 1;
	private int idEvento;
	private String nombre;
	private double costoRealizacion;
	private boolean benefico;
	private ArrayList<Funcion> funciones;
	private ArrayList<Artista> artistas;
	
	public Evento(String nombre, double costoRealizacion, boolean benefico){
		this.idEvento = correlativo;
		this.nombre = nombre;
		this.costoRealizacion = costoRealizacion;
		this.benefico = benefico;
		correlativo++;
	}
	
	public String getNombre(){
		return nombre;
	}
	
	public boolean getBenefico(){
		return benefico;
	}
	
	public void setFunciones(ArrayList<Funcion> funciones){
		this.funciones = funciones;
	}
	
	public ArrayList<Funcion> getFunciones(){
		return funciones;
	}
	
	public void setArtistas(ArrayList<Artista> artistas){
		this.artistas = artistas;
	}
	
	public ArrayList<Artista> getArtistas(){
		return artistas;
	}
	
	abstract public String consultarDatos();
	
	public String consultarDatosArtistasyFuncionesEvento(){
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		String cadena = "ARTISTAS: " + "\n";
		for(Artista artista : artistas){
			cadena += "- " + artista.consultarDatos();
		}
		cadena += "FUNCIONES: " + "\n";
		for(Funcion funcion : funciones){
			cadena += "- Fecha: " + sdf.format(funcion.getFecha()) + " - Hora Inicio:" +
					funcion.getHoraInicio() + " en " + funcion.getLocal().getNombre() + "\n";
		}
		return cadena;
	}
	
}