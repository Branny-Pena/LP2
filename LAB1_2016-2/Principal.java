import java.text.SimpleDateFormat;
import java.util.ArrayList;

public class Principal {
    public static void main(String[] args) throws Exception{
        EQuipu objEQuipu = new EQuipu();

        Equipo objEquipo1 = new Equipo("HCI-DUXAIT", "Temas de interaccion Humano-Computador");
        
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        Alumno objAlumno1 = new Alumno(68.3, "20090606", "Juan", "Perez", sdf.parse("20-03-1996"), "Av Padre Urraca 140",
                                "jperez@pucp.edu.pe", 'M');

        Profesor objProfesor1 = new Profesor(Dedicacion.TC, "46891", "Andrea", "Montenegro", sdf.parse("30-10-1990"),
                                            "Av. La Marina 362", "amontenegro@pucp.edu.pe", 'F');
        
        Alumno objAlumno2 = new Alumno(64.5, "20096969", "Viviana", "Rivasplata", sdf.parse("22-03-2000"), "Av La Marina 1240",
                                "vrivasplata@pucp.edu.pe", 'F');
        
        objEquipo1.setMiembros(new ArrayList<Miembro>());

        objEquipo1.getMiembros().add(objAlumno1);
        objEquipo1.getMiembros().add(objProfesor1);
        objEquipo1.getMiembros().add(objAlumno2);

        objEQuipu.setEquipos(new ArrayList<Equipo>());
        objEQuipu.getEquipos().add(objEquipo1);

        String reporte = objEQuipu.consultarMiembrosDeEquipo(0);
        System.out.println(reporte);
    }
}
