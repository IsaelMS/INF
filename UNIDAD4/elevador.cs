using System;

public class Elevador
{
    private string marca;
    private bool puerta=false;
    private int piso = 1;
    private int nuevoPiso;
    private string estado;
    private string direccion;
    private int date1;
    

    public Elevador()
    {
        marca = "ELEVATORWELL";
        piso = 1;
        estado = "DETENIDO";
        direccion = null;
        date1 = DateTime.Now.Hour;
    }
    public void setNuevoPiso(int n)
    {
        
        //VALIDANDO HORARIO DE SERVICIO
        if(date1<7 && date1>19)
        {
            Console.WriteLine("Elevador Apagado.\nHorario de servicio: 7:00AM - 7:00PM.");
            Console.ReadKey();
            Environment.Exit(0);
            
        }
        else
        {
            //VALIDANDO PISO SEA DIFERENTE AL ACUTAL Y EN EL RANGO ESTABLECIDO
            while(n<1 || n>33 || n == piso)
            {
                Console.Clear();
                

                if (n == piso)
                {
                    Console.WriteLine("Ya se encuentra en el piso indicado.");
                    Console.Write("\nIngrese otra opcion:");
                    n = int.Parse(Console.ReadLine());
                }
                else if(n == 0)
                {
                    Console.WriteLine("El programa ha finalizado");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Opcion invalida.\nPisos del 1 al 33.");
                    Console.Write("\nIngrese otra opcion:");
                    n = int.Parse(Console.ReadLine());
                }
            }

            this.nuevoPiso = n;
            
            puerta = true;
            estado = "Operando";

            if(n>piso)
            {
                direccion = "Subiendo";
            }
            else
            {
                direccion = "Bajando";
            }
        }
        
    }

    public void desplegarInformacion()
    {

        Console.Clear();
        Console.WriteLine("\t*****Informacion del Eleveador*****");
        Console.WriteLine("Marca: {0}", marca);
        Console.WriteLine("Puerta cerrada: {0}", puerta);
        Console.WriteLine("Piso actual: {0}", piso);
        Console.WriteLine("Nuevo piso: {0}", nuevoPiso);
        Console.WriteLine("Estado: {0}", estado);
        Console.WriteLine("Direccion: {0}", direccion);
        Console.ReadKey();


    }

    
    public void desplegarInformacion2()
    {
        puerta = false;
        estado = "Detenido";
        direccion = "N/A";
        this.piso = nuevoPiso;
        Console.Clear();
        Console.WriteLine("\t*****Informacion del Eleveador*****");
        Console.WriteLine("Marca: {0}", marca);
        Console.WriteLine("Puerta cerrada: {0}", puerta);
        Console.WriteLine("Piso actual: {0}", this.nuevoPiso);
        Console.WriteLine("Estado: {0}", estado);
        Console.WriteLine("Direccion: {0}", direccion);
        Console.ReadKey();
        Console.Clear();

    }


}

public class Tester
{

    static void Main()
    {
        
        int n;

        Elevador elevador1 =new Elevador();
        

        Console.WriteLine("Isael Mendez\n100429639");
        Console.WriteLine("\nBienvenido a ELEVATORWELL.\nPóngase cómodo y seleccione un piso hacia donde quiere ir.");

        do
        {
            
            
            Console.WriteLine("\n(Ingrese cero(0) para finalizar)\nNuevo piso: ");
            n = int.Parse(Console.ReadLine());
            
            if(n==0)
            {
                Console.WriteLine("El programa ha finalizado");
                Console.ReadKey();
                break;
            }
            

            elevador1.setNuevoPiso(n);

            elevador1.desplegarInformacion();
            elevador1.desplegarInformacion2();

        } while(n!=0);
    }
}
