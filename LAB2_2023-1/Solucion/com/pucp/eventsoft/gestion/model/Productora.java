package com.pucp.eventsoft.gestion.model;

import java.util.ArrayList;

public class Productora{
	private int idProductora;
	private String nombre;
	private ArrayList<Evento> eventos;
	
	public Productora(){}
	
	public Productora(int idProductora, String nombre){
		this.idProductora = idProductora;
		this.nombre = nombre;
	}
	
	public void setIdProductora(int idProductora){
		this.idProductora = idProductora;
	}
	public int getIdProductora(){
		return idProductora;
	}
	
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	public String getNombre(){
		return nombre;
	}
	
	public ArrayList<Evento> getEventos(){
		return eventos;
	}
	public void setEventos(ArrayList<Evento> eventos){
		this.eventos = eventos;
	}
	
	public String consultarEventos(){
		String cadena = "";
		for(Evento evento : eventos){
			cadena += evento.consultarDatos();
		}
		return cadena;
	}
}