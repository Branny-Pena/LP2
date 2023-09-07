package com.pucp.eventsoft.logistica.model;

public class Local{
	private int idLocal;
	private String nombre;
	private String direccion;
	private int capacidad;
	
	public Local(){}

	public Local(String nombre, String direccion, int capacidad){
		this.nombre = nombre;
		this.direccion = direccion;
		this.capacidad = capacidad;
	}
	
	public int getIdLocal(){
		return idLocal;
	}
	public void setIdLocal(int idLocal){
		this.idLocal = idLocal;
	}
	
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	public String getNombre(){
		return nombre;
	}
	
	public void setDireccion(String direccion){
		this.direccion = direccion;
	}
	public String getDireccion(){
		return direccion;
	}
	
	public void setCapacidad(int capacidad){
		this.capacidad = capacidad;
	}
	public int getCapacidad(){
		return capacidad;
	}
}