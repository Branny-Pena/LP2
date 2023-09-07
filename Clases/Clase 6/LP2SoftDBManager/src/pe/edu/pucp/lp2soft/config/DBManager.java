/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.lp2soft.config;
import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author adalb
 */
public class DBManager{
    private Connection con;
    private static DBManager dbManager = new DBManager();
    private String url = "jdbc:mysql://" + 
            "db-lp2-branny.clsnqoojnhgq.us-east-1.rds.amazonaws.com" +
            ":3306/lp2_Branny";
    private String username = "admin";
    private String password = "Penalead135";
    
    public Connection getConnection(){
        try{
            //Registrar el driver de conexion JDBC
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion con la base de datos
            con = DriverManager.getConnection(url, username, password);
            System.out.println("Se ha establecido la conexion con la base de datos");
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        return dbManager;
    }
}
