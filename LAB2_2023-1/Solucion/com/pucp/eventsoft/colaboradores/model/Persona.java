package com.pucp.eventsoft.colaboradores.model;
import java.util.Date;
import java.text.SimpleDateFormat;

public class Persona extends Artista{
	private String nombre;
	private String apellido;
	private Date fechaNacimiento;
	private char genero;
	private boolean activo;
	
	public Persona(){}
	
	public Persona(String nombreArtistico, OrigenArtista origenArtista, String nombre, String apellido, Date fechaNacimiento, char genero){
		super(nombreArtistico, origenArtista);
		this.nombre = nombre;
		this.apellido = apellido;
		this.fechaNacimiento = fechaNacimiento;
		this.genero = genero;
	}
	
	public String getNombre(){
		return nombre;
	}
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	
	public String getApellido(){
		return apellido;
	}
	public void setApellido(String apellido){
		this.apellido = apellido;
	}
	
	public Date getFechaNacimiento(){
		return fechaNacimiento;
	}
	public void setFechaNacimiento(Date fechaNacimiento){
		this.fechaNacimiento = fechaNacimiento;
	}
	
	public char getGenero(){
		return genero;
	}
	public void setGenero(char genero){
		this.genero = genero;
	}
	
	public boolean isActivo(){
		return activo;
	}
	public void setActivo(boolean activo){
		this.activo = activo;
	}
	
	@Override
	public String consultarDatos(){
		return "PERSONA: " + getNombreArtistico() + " - " + getOrigenArtista() +"\n";
	}
	
	public void imprimirDatos(){
		try{
			SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
			System.out.println(getIdArtista() + ". " + getNombreArtistico() + " - " + getOrigenArtista() + " - " + nombre + " " + apellido + " - " + sdf.format(fechaNacimiento) + " - Genero: " + genero);
		}catch(Exception ex){
			System.out.println(ex.getMessage());
		}
	}
}