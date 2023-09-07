import java.util.ArrayList;

public class Equipo implements Consultable{
    private String nombre;
    private String interes;
    private ArrayList<Miembro> miembros;

    public Equipo(String nombre, String interes){
        this.nombre = nombre;
        this.interes = interes;
    }

    public void setNombre(String nombre){
        this.nombre = nombre;
    }

    public String getNombre(){
        return nombre;
    }

    public void setMiembros(ArrayList<Miembro> miembros){
        this.miembros = miembros;
    }

    public ArrayList<Miembro> getMiembros(){
        return miembros;
    }

    public String consultarDatos(){
        String cadena = "";
        for(Miembro miembro : miembros){
            if(miembro instanceof MiembroPUCP){
                cadena += ((MiembroPUCP)miembro).consultarDatos() + "\n";
            }
        }
        return cadena;
    }
}

