import java.util.ArrayList;
import java.time.LocalTime;
import java.text.SimpleDateFormat;

public class Principal {
    public static void main(String[] args) throws Exception {
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyy");

        Biblioteca biblioteca1 = new Biblioteca("Biblioteca Central", true);

        Cubiculo cub01 = new Cubiculo("101", 1, 3, true, true, true, true);
        Cubiculo cub02 = new Cubiculo("311", 3, 3, false, true, false, false);

        biblioteca1.setCubiculos(new ArrayList<>());
        biblioteca1.getCubiculos().add(cub01);
        //biblioteca1.getCubiculos().add(cub02); verificar como manejar el null

        MiembroPUCP persona1 = new Profesor("20022214", "JUAN", "ARENAS", Categoria.Auxiliar);
        MiembroPUCP persona2 = new Estudiante("20167441", "ROSANGELA", "VALENZUELA", true);
        MiembroPUCP persona3 = new Egresado("20140445", "DANIELA", "ARGUMANIS", true);

        Reserva reserva1 = new Reserva(sdf.parse("25-08-2022"), LocalTime.of(10, 00), LocalTime.of(11, 00));
        reserva1.setResponsables(new ArrayList<>());
        reserva1.getResponsables().add(persona1);
        reserva1.getResponsables().add(persona2);
        reserva1.getResponsables().add(persona3);

        cub01.setReservas(new ArrayList<>());
        cub01.getReservas().add(reserva1);

        MiembroPUCP persona4 = new Estudiante("20135096", "ESTEFANI", "SILVA", true);
        Reserva reserva2 = new Reserva(sdf.parse("25-08-2022"), LocalTime.of(11, 00), LocalTime.of(12, 00));
        reserva2.setResponsables(new ArrayList<>());
        reserva2.getResponsables().add(persona4);
        cub01.registrarReserva(reserva2);

        String reporte = biblioteca1.consultarReservasDelCubiculo("101", sdf.parse("25-08-2022"));
        System.out.println(reporte);
    }
}
