/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.smashsoft.services;

import java.rmi.Naming;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.smashsoft.dao.PlataformaDAO;
import pe.edu.pucp.smashsoft.model.Plataforma;

/**
 *
 * @author adalb
 */
@WebService(serviceName = "SmashSoftPlataformaService")
public class SmashSoftPlataformaService {
    private String IP = "localhost";
    private String puerto = "1234";
    private PlataformaDAO daoPlataforma = null;
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarPlataformasTodas")
    public ArrayList<Plataforma> listarPlataformasTodas(){
        ArrayList<Plataforma> plataformas = new ArrayList<>();
        try{
            daoPlataforma = (PlataformaDAO) Naming.lookup("//"+IP+":"+
                                        puerto+"/"+"daoPlataforma");
            plataformas = daoPlataforma.listarTodas();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return plataformas;
    }
}
