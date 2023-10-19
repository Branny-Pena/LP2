/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.smashsoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.smashsoft.dao.PlataformaDAO;
import pe.edu.pucp.smashsoft.model.Plataforma;
import pe.edu.pucp.smashsoft.mysql.PlataformaMySQL;

/**
 *
 * @author adalb
 */
@WebService(serviceName = "SmashSoftPlataformaService")
public class SmashSoftPlataformaService {
    private PlataformaDAO daoPlataforma = new PlataformaMySQL();
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarPlataformasTodas")
    public ArrayList<Plataforma> listarPlataformasTodas(){
        ArrayList<Plataforma> plataformas = new ArrayList<>();
        try{
            plataformas = daoPlataforma.listarTodas();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return plataformas;
    }
}
