package com.pucp.eventsoft.colaboradores.model;
import java.util.ArrayList;

public class Agrupacion extends Artista{
	private int anhoConformacion;
	private ArrayList<Persona> miembros;
	private boolean activo;
	
	public Agrupacion(){}
	
	public Agrupacion(String nombreArtistico, OrigenArtista origenArtista, int anhoConformacion){
		super(nombreArtistico, origenArtista);
		this.anhoConformacion = anhoConformacion;
	}
	
	public void setAnhoConformacion(int anhoConformacion){
		this.anhoConformacion = anhoConformacion;
	}
	
	public int getAnhoConformacion(){
		return anhoConformacion;
	}
	
	public void setMiembros(ArrayList<Persona> miembros){
		this.miembros = miembros;
	}
	
	public ArrayList<Persona> getMiembros(){
		return miembros;
	}
	
	public boolean isActivo(){
		return activo;
	}
	public void setActivo(boolean activo){
		this.activo = activo;
	}
	
	@Override
	public String consultarDatos(){
		return "AGRUPACION: " + getNombreArtistico() + " - " + getOrigenArtista() + " - " + anhoConformacion +"\n";
	}
}