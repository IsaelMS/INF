using System;

abstract class Animal
{
    private int legs;
    public Animal(){}
    public Animal(int legs)
    {
        this.legs = legs;
    }
    abstract public void walk();
    abstract public void eat();
}

interface Pet
{
    void getName();
    void setNanme(string name);
    void play();
}

class Spider : Animal
{
    public Spider(int legs):
    base(legs)
    {
        
    }
    public override void eat()
    {
        Console.WriteLine("\nLa Araña come.");
    }

    public override void walk()
    {
        
    }
}

class Cat : Animal, Pet
{
    private string name;
    
    public Cat(string name)
    {
        this.name = name;
    }

    private Cat(){}
    public void setNanme(string name)
    {
        this.name = name;
    }
    public void getName()
    {
        Console.WriteLine("Name: " + this.name);
    }

    public void play()
    {
        Console.WriteLine(this.name + " juega."); 
    }
    public override void eat()
    {
        Console.WriteLine(this.name + " come.");
    }

    public override void walk()
    {

    }
}

class Fish : Animal, Pet
{
    private string name;

    public Fish(string name)
    {
        this.name = name;
    }

    public void getName()
    {
        Console.WriteLine("\nName: " + this.name);
    }
    public void setNanme(string name)
    {
        this.name = name;
    }
    public void play()
    {
        Console.WriteLine(this.name + " juega."); 
    }
    public override void eat()
    {
        Console.WriteLine(this.name + " come.");
    }
    public override void walk()
    {
        Console.WriteLine(this.name + " no camina. Es un pez");
    }
    
}


class Tester
{
    static void Main()
    {

        Cat c1 = new Cat("Andromeda");
        c1.getName();
        c1.play();
        c1.eat();

        Spider s1 = new Spider(8);
        s1.eat();

        Fish f1 = new Fish("Centella");
        f1.getName();
        f1.play();
        f1.walk();
        f1.eat();


    }
}
