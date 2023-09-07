abstract public class Artista implements IConsultable{
	private String nombreArtistico;
	private OrigenArtista origen;
	
	public Artista(String nombreArtistico, OrigenArtista origen){
		this.nombreArtistico = nombreArtistico;
		this.origen = origen;
	}
	
	public String getNombre(){
		return nombreArtistico;
	}
	
	public OrigenArtista getOrigen(){
		return origen;
	}
	
	abstract public String consultarDatos();
}