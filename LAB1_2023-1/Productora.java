import java.util.ArrayList;

public class Productora{
	private static int correlativo = 1;
	private int idProductora;
	private String nombre;
	private ArrayList<Evento> eventos;
	
	public Productora(int idProductora, String nombre){
		this.idProductora = correlativo;
		this.nombre = nombre;
		correlativo++;
	}
	
	public void setEventos(ArrayList<Evento> eventos){
		this.eventos = eventos;
	}
	
	public ArrayList<Evento> getEventos(){
		return eventos;
	}
	
	public String consultarEventos(){
		String datos = "";
		for(Evento evento : eventos){
			if (evento instanceof Concierto){
				datos += ((Concierto)evento).consultarDatos();
			}
			else{
				datos += ((ObraTeatral)evento).consultarDatos();
			}
		}
		return datos;
	}
}