/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.smashsoft.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.smashsoft.dao.PersonajeDAO;
import pe.edu.pucp.smashsoft.model.Personaje;
import pe.edu.pucp.smashsoft.mysql.PersonajeMySQL;

/**
 *
 * @author adalb
 */
@WebService(serviceName = "SmashSoftPersonajeService")
public class SmashSoftPersonajeService {
    private PersonajeDAO daoPersonaje = new PersonajeMySQL();
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "insertarPersonaje")
    public int insertarPersonaje(@WebParam(name = "personaje") Personaje personaje) {
        int resultado = 0;
        try{
            resultado = daoPersonaje.insertar(personaje);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
