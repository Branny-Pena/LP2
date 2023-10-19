package pe.edu.pucp.smashsoft.config;

import java.sql.Connection;
import java.sql.DriverManager;

public class DBManager {
    private static DBManager dbManager;
    //Colocar datos de conexion
    private String url = "jdbc:mysql://"+
            "db-lp2-branny.clsnqoojnhgq.us-east-1.rds.amazonaws.com"+
            ":3306/"+"LAB12_2023-1?useSSL=false";
    private String user = "admin";
    private String password = "Penalead135";
    private Connection con;
    
    public Connection getConnection(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(url, user, password);     
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if(dbManager == null){
            createInstance();
        }
        return dbManager;
    }
    
    private synchronized static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();
        }
    }
}
