package com.pucp.eventsoft.gestion.model;

public class ObraTeatral extends Evento{
	private int cantTotalActos;
	private boolean esInmersiva;
	
	public ObraTeatral(){}
	
	public ObraTeatral(String nombre, double costoRealizacion, boolean esBenefico, int cantTotalActos, boolean esInmersiva){
		super(nombre,costoRealizacion,esBenefico);
		this.cantTotalActos = cantTotalActos;
		this.esInmersiva = esInmersiva;
	}
	
	public int getCantTotalActos(){
		return cantTotalActos;
	}
	public void setCantTotalActos(int cantTotalActos){
		this.cantTotalActos = cantTotalActos;
	}
	
	public boolean isEsInmersiva(){
		return esInmersiva;
	}
	public void setEsInmersiva(boolean esInmersiva){
		this.esInmersiva = esInmersiva;
	}
	
	public String consultarDatos(){
		String benefico = (isEsBenefico())?"SI":"NO";
		String inmersiva = (esInmersiva)?"SI":"NO";
		String cadena = "OBRA TEATRAL: " + getNombre() + " - BENEFICA:" + benefico + " - INMERSIVA:" + inmersiva +"\n";
		cadena += super.consultarDatosArtistasyFuncionesEvento();
		return cadena;
	}
}