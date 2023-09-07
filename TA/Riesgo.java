import java.util.Date;
import java.util.ArrayList;

public class Riesgo implements Interfaz{
    private static int correlativo = 1;
    private String idRiesgo;
    private String riesgo;
    private String descripcionRiesgo;
    private ProcesoDeNegocio procesoDeNegocio;
    private TipoTaxonomia tipoTaxonomia; //TI/No TI
    private Division division;
    private Usuario evaluador;
    private Usuario revisor;
    private Usuario aprobador;
    private Estrategia estrategia;
    private RiesgoResidual riesgoResidual;
    private double exposicionResidual;
    private Aplicacion aplicacion;
    private MetodoDeMedicion metodoDeMedicion;
    private boolean activado;
    private Date fechaPrimeraPublicacion;
    private ArrayList<PlanDeAccion> planesDeAccion;

    public String consultarDatos(){
        return "";
    }
}