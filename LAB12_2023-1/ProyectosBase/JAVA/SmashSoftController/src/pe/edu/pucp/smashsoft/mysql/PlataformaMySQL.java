/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.smashsoft.mysql;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.smashsoft.config.DBManager;
import pe.edu.pucp.smashsoft.dao.PlataformaDAO;
import pe.edu.pucp.smashsoft.model.Plataforma;

/**
 *
 * @author adalb
 */
public class PlataformaMySQL extends UnicastRemoteObject implements PlataformaDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    public PlataformaMySQL(int puerto)throws RemoteException{
        super(puerto);
    }
    
    @Override
    public ArrayList<Plataforma> listarTodas() throws RemoteException{
        ArrayList<Plataforma> plataformas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PLATAFORMAS_TODAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Plataforma plataforma = new Plataforma();
                plataforma.setIdPlataforma(rs.getInt("id_plataforma"));
                plataforma.setNombre(rs.getString("nombre"));
                plataformas.add(plataforma);
                System.out.println(plataforma.getNombre());
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return plataformas;
    }
    
}
