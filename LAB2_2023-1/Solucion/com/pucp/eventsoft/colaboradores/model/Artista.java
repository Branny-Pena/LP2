package com.pucp.eventsoft.colaboradores.model;

public abstract class Artista implements IConsultable{
	private int idArtista;
	private String nombreArtistico;
	private OrigenArtista origenArtista;
	
	public Artista(){}
	
	public Artista(String nombreArtistico, OrigenArtista origenArtista){
		this.nombreArtistico = nombreArtistico;
		this.origenArtista = origenArtista;
	}
	
	public int getIdArtista(){
		return idArtista;
	}
	public void setIdArtista(int idArtista){
		this.idArtista = idArtista;
	}
	
	public String getNombreArtistico(){
		return nombreArtistico;
	}
	public void setNombreArtistico(String nombreArtistico){
		this.nombreArtistico = nombreArtistico;
	}
	
	public OrigenArtista getOrigenArtista(){
		return origenArtista;
	}
	public void setOrigenArtista(OrigenArtista origenArtista){
		this.origenArtista = origenArtista;
	}
	
	public abstract String consultarDatos();
}