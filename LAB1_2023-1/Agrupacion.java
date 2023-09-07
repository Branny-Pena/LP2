import java.util.ArrayList;

public class Agrupacion extends Artista{
	private int anioConformacion;
	private ArrayList<Persona> miembros;
	
	public Agrupacion(String nombreArtistico, OrigenArtista origen, int anioConformacion){
		super(nombreArtistico, origen);
		this.anioConformacion = anioConformacion;
	}
	
	public void setMiembros(ArrayList<Persona> miembros){
		this.miembros = miembros;
	}
	
	public ArrayList<Persona> getMiembros(){
		return miembros;
	}
	
	@Override
	public String consultarDatos(){
		return "AGRUPACION: " + super.getNombre() + " - " + super.getOrigen() +
				" - " + anioConformacion + "\n";
	}
}	