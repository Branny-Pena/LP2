/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.main;

import java.util.ArrayList;
import pe.edu.pucp.smashsoft.dao.PersonajeDAO;
import pe.edu.pucp.smashsoft.dao.PlataformaDAO;
import pe.edu.pucp.smashsoft.model.Personaje;
import pe.edu.pucp.smashsoft.model.Plataforma;
import pe.edu.pucp.smashsoft.model.Universo;
import pe.edu.pucp.smashsoft.mysql.PersonajeMySQL;
import pe.edu.pucp.smashsoft.mysql.PlataformaMySQL;

/**
 *
 * @author adalb
 */
public class Principal {
    private static PersonajeDAO daoPersonaje = new PersonajeMySQL();
    private static PlataformaDAO daoPlataforma = new PlataformaMySQL();
    public static void main(String[] args){
        Personaje personaje = new Personaje();
        Plataforma plataforma = new Plataforma();
        Universo universo = new Universo();
        personaje.setPlataforma(plataforma);
        personaje.setUniverso(universo);
        personaje.setNombre("asda");
        personaje.setDescripcion("asdsasgadlfgasdg");
        personaje.getUniverso().setIdUniverso(1);
        personaje.getPlataforma().setIdPlataforma(1);
        ArrayList<Plataforma> plataformas = daoPlataforma.listarTodas();
        for(Plataforma p:plataformas){
            System.out.println(p.getNombre());
        }
//        int resultado = daoPersonaje.insertar(personaje);
//        if(resultado == 0){
//            System.out.println("ERROR");
//        }
    }
}
