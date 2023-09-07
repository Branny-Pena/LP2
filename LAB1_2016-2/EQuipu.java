import java.util.ArrayList;

class EQuipu{
    private ArrayList<Equipo> equipos;
    private ArrayList<Miembro> ejecutivos;

    public void setEquipos(ArrayList<Equipo> equipos){
        this.equipos = equipos;
    }

    public ArrayList<Equipo> getEquipos(){
        return equipos;
    }

    public String consultarMiembrosDeEquipo(int indice){
        return equipos.get(indice).consultarDatos();
    }
}