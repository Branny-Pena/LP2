/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2soft.getclientes.model;
import java.util.Date;
import pe.edu.pucp.lp2soft.rrhh.model.Persona;

/**
 *
 * @author adalb
 */
public class Cliente extends Persona{
    private double lineaCredito;
    private Categoria categoria;

    public Cliente(double lineaCredito, Categoria categoria, int idPersona, String DNI, String nombre, String apellidoPaterno, char genero, Date fechaNacimiento) {
        super(DNI, nombre, apellidoPaterno, genero, fechaNacimiento);
        this.lineaCredito = lineaCredito;
        this.categoria = categoria;
    }

    public double getLineaCredito() {
        return lineaCredito;
    }

    public void setLineaCredito(double lineaCredito) {
        this.lineaCredito = lineaCredito;
    }

    public Categoria getCategoria() {
        return categoria;
    }

    public void setCategoria(Categoria categoria) {
        this.categoria = categoria;
    }
}
