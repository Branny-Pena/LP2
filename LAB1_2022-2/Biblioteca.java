import java.util.Date;
import java.util.ArrayList;

public class Biblioteca {
    private String nombre;
    private boolean dentroCampus;
    private ArrayList<Cubiculo> cubiculo;

    public Biblioteca(String nombre, boolean dentroCampus){
        this.nombre = nombre;
        this.dentroCampus = dentroCampus;
    }

    public void setCubiculos(ArrayList<Cubiculo> cubiculo){
        this.cubiculo = cubiculo;
    }

    public ArrayList<Cubiculo> getCubiculos(){
        return cubiculo;
    }

    public String consultarReservasDelCubiculo(String nombreCub, Date fecha){
        String datos = "";
        for(int i = 0; i < cubiculo.size(); i++){
            if(nombreCub == cubiculo.get(i).getNombre()){
                datos += cubiculo.get(i).consultarDatos(nombre, nombreCub, fecha);
            }
        }
        return datos;
    }
}
