public class ObraTeatral extends Evento{
	private int cantidadActos;
	private boolean inmersiva;
	
	public ObraTeatral(String nombre, double costoRealizacion, boolean benefico,
						int cantidadActos, boolean inmersiva){
		super(nombre, costoRealizacion, benefico);
		this.cantidadActos = cantidadActos;
		this.inmersiva = inmersiva;
	}
	
	@Override
	public String consultarDatos(){
		String datos = "OBRA TEATRAL: " + super.getNombre() + " - BENEFICA: " + 
				super.getBenefico() + " - INNMERSIVA: " + inmersiva + "\n";
		datos += super.consultarDatosArtistasyFuncionesEvento();
		return datos;
	}
}