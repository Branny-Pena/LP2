package com.pucp.eventsoft.gestion.model;

public class Concierto extends Evento{
	private boolean esAcustico;
	private boolean tecnologiaAsistiva;
	
	public Concierto(){}
	
	public Concierto(String nombre, double costoRealizacion, boolean esBenefico, boolean esAcustico, boolean tecnologiaAsistiva){
		super(nombre, costoRealizacion, esBenefico);
		this.esAcustico = esAcustico;
		this.tecnologiaAsistiva = tecnologiaAsistiva;
	}
	
	public boolean isEsAcustico() {
        return esAcustico;
    }
    public void setEsAcustico(boolean esAcustico) {
        this.esAcustico = esAcustico;
    }
	
	public boolean isTecnologiaAsistiva(){
		return tecnologiaAsistiva;
	}
	public void setTecnologiaAsistiva(boolean tecnologiaAsistiva){
		this.tecnologiaAsistiva = tecnologiaAsistiva;
	}
	
	public String consultarDatos(){
		String asistiva = (tecnologiaAsistiva)?"SI":"NO";
		String acustico = (esAcustico)?"SI":"NO";
		String cadena =  "CONCIERTO: " + getNombre() + " - ACUSTICO:" + acustico + " - TEC ASISTIVA:" + asistiva +"\n";
		cadena += super.consultarDatosArtistasyFuncionesEvento();
		return cadena;
	}
}