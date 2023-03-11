using System;

public class Prestamo {

    private double cantidad;
    private int tiempo;
    private double interes;
    private double interesTotal;
    private string prestamista = "Financiera Mendez";
    private string prestatario;
    private double cuotaMensual;
    ///////////////////////////////////////////////////
    public  void setCantidad(double cantidad){
        this.cantidad = cantidad;
    }
    public double getCantidad(){
        return this.cantidad;
    }
    ////////////////////////////////////////////////////
    public void setTiempo(int tiempo){
        this.tiempo = tiempo;
    }
    public int getTiempo(){
        return this.tiempo;
    }
    /////////////////////////////////////////////////////
    public void setInteres(double interes){
        this.interes = Math.Round((interes/100), 6);
        interesTotal = Math.Round((((this.interes*cantidad)*(tiempo))/12), 2);
        
    }
    public double getInteres(){
        return this.interes;
    }
    /////////////////////////////////////////////////////
    public void setPrestatario(string prestatario){
        this.prestatario = prestatario;
    }
    public string getPrestatario(){
        return this.prestatario;
    }
    /////////////////////////////////////////////////////
    public void deplegarInformacion(){

        Console.WriteLine("\n\n\t*****Resumen*****\n");
        Console.WriteLine("Nombre del prestatario: {0}", prestatario);
        Console.WriteLine("Entidad financiera: {0}", prestamista);
        Console.WriteLine("Timepo en meses: {0}", tiempo);
        Console.WriteLine("Tasa de interes anual: " + (interes*100));
        Console.WriteLine("Cantidad solicitada: {0}", cantidad);
        Console.WriteLine("Interes total: " + interesTotal);
        cuotaMensual = ((cantidad+(interesTotal))/tiempo);
        cuotaMensual = Math.Round(cuotaMensual, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine("Cantidad + interes total: " + (cantidad + interesTotal));
        Console.WriteLine("Cuota mensual: {0}", cuotaMensual);
        Console.ReadLine();

    }


}

public class PrestamoTest{
    static void Main(){

        Prestamo prestamo1 = new Prestamo();
        Console.Clear();

        Console.WriteLine("Isael Mendez\n100429639\n");
        string mensaje = "Calculo de prestamo.\nFavor de ingresar la informacion solicitada.";

        Console.WriteLine(mensaje);
        Console.WriteLine("\nNombre del prestatario: ");
        prestamo1.setPrestatario(Console.ReadLine());
        Console.WriteLine("Cantidad: ");
        prestamo1.setCantidad(double.Parse(Console.ReadLine()));
        Console.WriteLine("Timepo en meses: ");
        prestamo1.setTiempo(int.Parse(Console.ReadLine()));
        Console.WriteLine("Tasa de interes anual: ");
        prestamo1.setInteres(double.Parse(Console.ReadLine()));

        prestamo1.deplegarInformacion();

    }

}
