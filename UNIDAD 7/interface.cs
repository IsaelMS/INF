using System;

interface Flyer
{
    void takeoff(string x);
    void fly(string x);
    void land(string x);
}

public class Animal
{
    public virtual void eat(string x)
    {
        Console.WriteLine("El " + x + " come.");
    }
}

public class vehicle
{

}


public class Airplane : vehicle, Flyer
{
    protected string vehicle = "vehiculo";

    public  void takeoff(string x)
    {
        Console.WriteLine("\nEl " + x + " despega.");
    }
    public  void fly(string x)
    {
        Console.WriteLine("El " + x + " vuela.");
    }
    public  void land(string x)
    {
        Console.WriteLine("El " + x + " aterriza.");
    }

    public void mostrar()
    {
        Console.WriteLine("Seapleane o Helicoptero:");
        takeoff(vehicle);
        fly(vehicle);
        land(vehicle);
    }
}



public class Bird : Animal, Flyer
{
    protected string animal = "Ave";

    public override void eat(string x)
    {
        base.eat(x);
    }
    public void takeoff(string x)
    {
        Console.WriteLine("El " + x + " despega.");
    }
    public void fly(string x)
    {
        Console.WriteLine("El " + x + " vuela.");
    }
    public void land(string x)
    {
       Console.WriteLine("El " + x + " aterriza.");
    }
    public void buildNest(string x)
    {
        Console.WriteLine("El "+ x + " construye un nido.");
    }
    public void layEggs(string x)
    {
        Console.WriteLine("El "+ x + " pone huevos.");
    }
    

    public void mostrar()
    {
        Console.WriteLine("\n\nEL Ave:");
        takeoff(animal);
        fly(animal);
        land(animal);
        buildNest(animal);
        layEggs(animal);
        eat(animal);
    }
}

public class Kryptonian : Animal
{

}

public class Superman : Kryptonian, Flyer
{
    protected string superman = "Kryptoniano";

    
    public override void eat(string x)
    {
        base.eat(x);
    }
    public void takeoff(string x)
    {
        Console.WriteLine("El " + x + " despega.");
    }
    public  void fly(string x)
    {
        Console.WriteLine("El " + x + " vuela.");
    }
    public  void land(string x)
    {
        Console.WriteLine("El " + x + " aterriza.");
    }
    public void leapBuilding(string x)
    {
        Console.WriteLine("El "+ x + " salta edificios.");
    }
    public void stopBullet(string x)
    {
        Console.WriteLine("El "+ x + " detiene balas.");
    }
   

    public void mostrar()
    {
        Console.WriteLine("\n\nSuperman:");
        takeoff(superman);
        fly(superman);
        land(superman);
        leapBuilding(superman);
        stopBullet(superman);
        eat(superman);
    }

}

class Seaplane : Airplane
{

}

class Helicoptero : Airplane
{

}

public class Tester
{
    static void Main()
    {
        Bird bird = new Bird();
        bird.mostrar();

        Superman superman = new Superman();
        superman.mostrar();

        Seaplane s1 = new Seaplane();
        s1.takeoff("Seaplane");
        s1.land("Seaplane");
        s1.fly("Seaplane");

        Helicoptero h1 = new Helicoptero();
        h1.takeoff("Helicoptero");
        h1.land("Helicoptero");
        h1.fly("Helicoptero");


    }
}
