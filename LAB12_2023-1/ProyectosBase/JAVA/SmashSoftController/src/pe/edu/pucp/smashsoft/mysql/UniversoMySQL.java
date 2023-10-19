/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.smashsoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.smashsoft.config.DBManager;
import pe.edu.pucp.smashsoft.dao.UniversoDAO;
import pe.edu.pucp.smashsoft.model.Universo;

/**
 *
 * @author adalb
 */
public class UniversoMySQL implements UniversoDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public ArrayList<Universo> listarPorNombre(String nombre){
        ArrayList<Universo> universos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_UNIVERSOS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Universo universo = new Universo();
                universo.setIdUniverso(rs.getInt("id_universo"));
                universo.setNombre(rs.getString("nombre"));
                universos.add(universo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return universos;
    }
}
