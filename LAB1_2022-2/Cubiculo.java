import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class Cubiculo{
    private String nombre;
    private int piso;
    private int aforo;
    private boolean televisor;
    private boolean pizarra;
    private boolean proyector;
    private boolean computador;
    private ArrayList<Reserva> reserva;

    public Cubiculo(String nombre, int piso, int aforo, boolean televisor, boolean pizarra,
                    boolean proyector, boolean computador){
        this.nombre = nombre;
        this.piso = piso;
        this.aforo = aforo;
        this.televisor = televisor;
        this.pizarra = pizarra;
        this.proyector = proyector;
        this.computador = computador;
    }

    public void setReservas(ArrayList<Reserva> reserva){
        this.reserva = reserva;
    }

    public ArrayList<Reserva> getReservas(){
        return reserva;
    }

    public void registrarReserva(Reserva reserva){
        this.reserva.add(reserva);
    }

    public String getNombre(){
        return nombre;
    }

    public String consultarDatos(String nombreBib, String nombre, Date fecha){
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        String dato = "Reservas del cubiculo " + nombre + " de la " + nombreBib + " para " + sdf.format(fecha) + "\n";
        if(reserva.isEmpty()) return dato;
        for(int i = 0; i < reserva.size(); i++){
            if(reserva.get(i).getFecha().equals(fecha))
                dato += reserva.get(i).consultarDatos();
        }
        return dato;
    }

}
