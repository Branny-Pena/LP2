import java.util.Date;
import java.time.LocalTime;

public class Funcion{
	private Date fecha;
	private LocalTime horaInicio;
	private LocalTime horaFin;
	private Local local;
	
	public Funcion(Date fecha, LocalTime horaInicio, LocalTime horaFin, Local local){
		this.fecha = fecha;
		this.horaInicio = horaInicio;
		this.horaFin = horaFin;
		this.local = local;
	}
	
	public Date getFecha(){
		return fecha;
	}
	
	public LocalTime getHoraInicio(){
		return horaInicio;
	}
	
	public LocalTime getHoraFin(){
		return horaFin;
	}
	
	public Local getLocal(){
		return local;
	}
}