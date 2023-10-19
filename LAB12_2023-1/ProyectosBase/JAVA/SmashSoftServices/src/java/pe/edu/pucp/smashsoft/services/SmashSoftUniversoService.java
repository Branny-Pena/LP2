/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.smashsoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.smashsoft.dao.UniversoDAO;
import pe.edu.pucp.smashsoft.model.Universo;
import pe.edu.pucp.smashsoft.mysql.UniversoMySQL;

/**
 *
 * @author adalb
 */
@WebService(serviceName = "SmashSoftUniversoService")
public class SmashSoftUniversoService {
    private UniversoDAO daoUniverso = new UniversoMySQL();
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarUniversosPorNombre")
    public ArrayList<Universo> listarUniversosPorNombre(@WebParam(name = "nombre") String nombre) {
        ArrayList<Universo> universos = new ArrayList<>();
        try{
            universos = daoUniverso.listarPorNombre(nombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return universos;
    }
}
