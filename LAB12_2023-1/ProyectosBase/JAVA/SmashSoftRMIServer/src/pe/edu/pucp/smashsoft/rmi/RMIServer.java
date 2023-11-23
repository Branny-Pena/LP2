/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.smashsoft.rmi;

import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;
import pe.edu.pucp.smashsoft.dao.PersonajeDAO;
import pe.edu.pucp.smashsoft.dao.PlataformaDAO;
import pe.edu.pucp.smashsoft.dao.UniversoDAO;
import pe.edu.pucp.smashsoft.mysql.PersonajeMySQL;
import pe.edu.pucp.smashsoft.mysql.PlataformaMySQL;
import pe.edu.pucp.smashsoft.mysql.UniversoMySQL;

/**
 *
 * @author adalb
 */
public class RMIServer {
    private static String IP = "localhost";
    private static String puerto = "1234";
    public static void main(String[] args){
            try{
                LocateRegistry.createRegistry(Integer.parseInt(puerto));
                PersonajeDAO daoPersonaje = new PersonajeMySQL(Integer.parseInt(puerto));
                Naming.rebind("//" + IP + ":" + puerto + "/daoPersonaje", daoPersonaje);
                
                PlataformaDAO daoPlataforma = new PlataformaMySQL(Integer.parseInt(puerto));
                Naming.rebind("//" + IP + ":" + puerto + "/daoPlataforma", daoPersonaje);
                
                UniversoDAO daoUniverso = new UniversoMySQL(Integer.parseInt(puerto));
                Naming.rebind("//" + IP + ":" + puerto + "/daoUniverso", daoPersonaje);
                
                System.out.println("Se ha desplegado el servidor...");
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
    }
            
}
