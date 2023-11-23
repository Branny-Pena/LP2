/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.smashsoft.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import pe.edu.pucp.smashsoft.model.Personaje;

/**
 *
 * @author adalb
 */
public interface PersonajeDAO extends Remote{
    int insertar(Personaje personaje) throws RemoteException;
}
