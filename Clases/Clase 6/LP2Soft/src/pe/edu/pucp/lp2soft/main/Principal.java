package pe.edu.pucp.lp2soft.main;
import java.sql.Connection;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.almacen.model.Producto;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.gestclientes.model.Categoria;
import pe.edu.pucp.lp2soft.gestclientes.model.Cliente;
import pe.edu.pucp.lp2soft.rrhh.model.Area;
import pe.edu.pucp.lp2soft.rrhh.model.Empleado;
import pe.edu.pucp.lp2soft.ventas.model.LineaOrdenVenta;
import pe.edu.pucp.lp2soft.ventas.model.OrdenVenta;
public class Principal {
    public static void main(String[] args) throws Exception{
        /*SimpleDateFormat sdf = 
                new SimpleDateFormat("dd-MM-yyyy");
        Area area1 = new Area("VENTAS");
        Empleado emp1 = new Empleado(
                "12345678", "JUAN", "PEREZ", 
                'M', 
                sdf.parse("01-01-1992"), 
                area1, "CAJERO", 3000.00);
        Cliente cliente1 = new Cliente("29827212", "MANUEL", 
                "SANDOVAL", 'M', 
                sdf.parse("19-10-1987"), 2000.00, 
                Categoria.VIP);
        
        OrdenVenta ov1 = new OrdenVenta();
        ov1.setCliente(cliente1);
        ov1.setEmpleado(emp1);
        
        Producto producto1 = new Producto("COCA COLA", 
                "1 LT",6.00);
        Producto producto2 = new Producto("LAVAVAJILLA SAPOLIA",
        "500 mg", 14.00);
        
        LineaOrdenVenta lov1 = 
                new LineaOrdenVenta(producto1,3);
        LineaOrdenVenta lov2 = 
                new LineaOrdenVenta(producto2,2);
        
        ov1.setLineasOrdenVenta(new ArrayList<>());
        ov1.getLineasOrdenVenta().add(lov1);
        ov1.getLineasOrdenVenta().add(lov2);
        
        ov1.calcularTotal();
        
        String reporte = ov1.generarReporte();
        System.out.print(reporte);*/
        Connection con = DBManager.getInstance().getConnection();
        Statement st = con.createStatement();
        String sql = "INSERT INTO area(nombre, activa) VALUES ('RECURSOS HUMANOS', 1)";
        //Insert, update, delete
        st.executeUpdate(sql);
        con.close();
    }
}
