import java.util.ArrayList;
import java.text.SimpleDateFormat;
import java.time.LocalTime;

class Principal{
	public static void main(String[] args) throws Exception{
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		
		Productora prod01 = new Productora(1, "Artes PERU");
		prod01.setEventos(new ArrayList<>());
		
		Concierto concert01 = new Concierto("ENANITOS VERDES EN TRACCION ACUSTICA",
								10000.99, false, true, true);
		concert01.setFunciones(new ArrayList<>());
		
		Local local01 = new Local("GRAN TEATRO NACIONAL", "Av Javier Prado Este 2225",
						1500);
		Local local02 = new Local("TEATRO PERUANO JAPONES", "Av. Gregorio Escobedo 803",
						1025);
						
		Funcion funcion01 = new Funcion(sdf.parse("01-04-2023"), LocalTime.of(20,00,00),
							LocalTime.of(22,00,00), local01);
		Funcion funcion02 = new Funcion(sdf.parse("02-04-2023"), LocalTime.of(20,00,00),
							LocalTime.of(22,00,00), local02);
		
		concert01.getFunciones().add(funcion01);
		concert01.getFunciones().add(funcion02);
		
		Persona per01 = new Persona("MARCIANO CANTERO", OrigenArtista.Internacional,
						"HORACIO", "CANTERO", sdf.parse("25-08-1960"), 'M');
		Persona per02 = new Persona("FELIPE STAITI", OrigenArtista.Internacional,
						"DANIEL", "STAITI", sdf.parse("29-08-1961"), 'M');
		Persona per03 = new Persona("DANIEL PICCOLO", OrigenArtista.Internacional,
						"DANIEL", "PICCOLO", sdf.parse("15-04-1959"), 'M');
		
		Agrupacion agrupacion01 = new Agrupacion("LOS ENANITOS VERDES", 
							OrigenArtista.Internacional, 1979);
		agrupacion01.setMiembros(new ArrayList<>());
		agrupacion01.getMiembros().add(per01);
		agrupacion01.getMiembros().add(per02);
		agrupacion01.getMiembros().add(per03);
		
		concert01.setArtistas(new ArrayList<>());
		concert01.getArtistas().add(agrupacion01);
		
		prod01.getEventos().add(concert01);
		
		ObraTeatral obrat01 = new ObraTeatral("AMAR LO QUE HACES", 10000.0, false,
								2, false);
								
		obrat01.setFunciones(new ArrayList<>());
		
		Funcion funcion03 =  new Funcion(sdf.parse("08-04-2023"),
						LocalTime.of(21,00,00),LocalTime.of(23,00,00),local01);
		
		obrat01.getFunciones().add(funcion03);
		
		Persona per04 = new Persona("WENDY RAMOS", OrigenArtista.Nacional,
						"JANET", "RAMOS", sdf.parse("1-12-1966"), 'F');
						
		obrat01.setArtistas(new ArrayList<>());
		obrat01.getArtistas().add(per04);
		
		prod01.getEventos().add(obrat01);
		
		String reporte = prod01.consultarEventos();
		
		System.out.print(reporte);
	}
}