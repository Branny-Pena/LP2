package com.pucp.eventsoft.gestion.model;

import java.util.ArrayList;
import java.text.SimpleDateFormat;
import com.pucp.eventsoft.colaboradores.model.IConsultable;
import com.pucp.eventsoft.colaboradores.model.Artista;
import com.pucp.eventsoft.logistica.model.Funcion;

public abstract class Evento implements IConsultable{
	private int idEvento;
	private String nombre;
	private double costoRealizacion;
	private boolean esBenefico;
	private ArrayList<Funcion> funciones;
	private ArrayList<Artista> artistas;

	public Evento(){}

	public Evento(String nombre, double costoRealizacion, boolean esBenefico){
		this.nombre = nombre;
		this.costoRealizacion = costoRealizacion;
		this.esBenefico = esBenefico;
	}
	
	public int getIdEvento(){
		return idEvento;
	}
	public void setIdEvento(int idEvento){
		this.idEvento = idEvento;
	}
	
	public String getNombre(){
		return nombre;
	}
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	
	public double getCostoRealizacion(){
		return costoRealizacion;
	}
	public void setCostoRealizacion(double costoRealizacion){
		this.costoRealizacion = costoRealizacion;
	}
	
	public boolean isEsBenefico(){
		return esBenefico;
	}
	public void setEsBenefico(boolean esBenefico){
		this.esBenefico = esBenefico;
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
	
	public abstract String consultarDatos();
	
	public String consultarDatosArtistasyFuncionesEvento(){
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		String cadena = "ARTISTAS: " + "\n";
		for(Artista artista : artistas){
			cadena += "- " + artista.consultarDatos();
		}
		cadena += "FUNCIONES: " + "\n";
		for(Funcion funcion : funciones){
			cadena += "- Fecha: " + sdf.format(funcion.getFecha()) + " - Hora Inicio:" + funcion.getHoraInicio() + " en " + funcion.getLocal().getNombre() + "\n"; 
		}
		return cadena;
	}
}