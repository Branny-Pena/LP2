/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.smashsoft.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.smashsoft.model.Plataforma;

/**
 *
 * @author adalb
 */
public interface PlataformaDAO extends Remote{
    ArrayList<Plataforma> listarTodas() throws RemoteException;
}
