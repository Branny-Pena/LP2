package pe.edu.pucp.smashsoft.model;

import java.io.Serializable;

public class Universo implements Serializable{
    private int idUniverso;
    private String nombre;
    private boolean activo;

    public int getIdUniverso() {
        return idUniverso;
    }

    public void setIdUniverso(int idUniverso) {
        this.idUniverso = idUniverso;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}