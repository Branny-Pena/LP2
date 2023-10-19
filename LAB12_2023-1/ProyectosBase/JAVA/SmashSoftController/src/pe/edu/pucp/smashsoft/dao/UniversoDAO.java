/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.smashsoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.smashsoft.model.Universo;

/**
 *
 * @author adalb
 */
public interface UniversoDAO {
    ArrayList<Universo> listarPorNombre(String nombre);
}
