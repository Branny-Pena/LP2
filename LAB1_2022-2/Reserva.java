import java.util.Date;
import java.time.LocalTime;
import java.util.ArrayList;

public class Reserva implements IConsultable{
    private static int correlativo = 1;
    private int idReserva;
    private Date fecha;
    private LocalTime horaInicio;
    private LocalTime horaFin;
    private ArrayList<MiembroPUCP> responsable;

    public Reserva(Date fecha, LocalTime horaInicio, LocalTime horaFin){
        this.idReserva = correlativo;
        this.fecha = fecha;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
        correlativo++;
    }

    public void setResponsables(ArrayList<MiembroPUCP> responsable){
        this.responsable = responsable;
    }

    public ArrayList<MiembroPUCP> getResponsables(){
        return responsable;
    }

    public Date getFecha(){
        return fecha;
    }

    public String consultarDatos(){
        String datos = "Reserva " + idReserva + ": de " + horaInicio + " a " + horaFin + "\n";
        for(int i = 0; i < responsable.size(); i++){
            datos += responsable.get(i).consultarDatos();
        }
        return datos;
    }
}
