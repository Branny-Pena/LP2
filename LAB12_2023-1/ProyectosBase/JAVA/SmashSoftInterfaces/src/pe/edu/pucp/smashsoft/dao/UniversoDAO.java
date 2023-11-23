/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.smashsoft.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.smashsoft.model.Universo;

/**
 *
 * @author adalb
 */
public interface UniversoDAO extends Remote{
    ArrayList<Universo> listarPorNombre(String nombre) throws RemoteException;
}
