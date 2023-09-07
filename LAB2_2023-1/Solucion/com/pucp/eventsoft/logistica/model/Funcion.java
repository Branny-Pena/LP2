package com.pucp.eventsoft.logistica.model;

import java.time.LocalTime;
import java.util.Date;

public class Funcion{
	private int idFuncion;
	private Date fecha;
	private LocalTime horaInicio;
	private LocalTime horaFin;
	private Local local;
	
	public Funcion(){}
	
	public Funcion(Date fecha, LocalTime horaInicio, LocalTime horaFin, Local local){
		this.fecha = fecha;
		this.horaInicio = horaInicio;
		this.horaFin = horaFin;
		this.local = local;
	}
	
	public void setIdFuncion(int idFuncion){
		this.idFuncion = idFuncion;
	}
	public int getIdFuncion(){
		return idFuncion;
	}
	
	public Date getFecha(){
		return fecha;
	}
	public void setFecha(Date fecha){
		this.fecha = fecha;
	}
	
	public LocalTime getHoraInicio(){
		return horaInicio;
	}
	public void setHoraInicio(LocalTime horaInicio){
		this.horaInicio = horaInicio;
	}
	
	public LocalTime getHoraFin(){
		return horaFin;
	}
	public void setHoraFin(LocalTime horaFin){
		this.horaFin = horaFin;
	}
	
	public Local getLocal(){
		return local;
	}
	public void setLocal(Local local){
		this.local = local;
	}
}