using System;

class Cuenta
{
    private int numeroCuenta;
    private double balance;

    public Cuenta(int numeroCuenta, double balance)
    {
        this.numeroCuenta = numeroCuenta;
        this.balance = balance;
    }

    public void setNumeroCuenta(int numeroCuenta)
    {
        this.numeroCuenta = numeroCuenta;
    }
    public void setBalance(double balance)
    {
        this.balance = this.balance + balance;
    }

    public int getNumeroCuenta()
    {
        return numeroCuenta;
    }
    public double getBalance()
    {
        return balance;
    }

}

class CuentaAhorro : Cuenta
{
    private double tasa;
    private DateTime fechaCarga;

    public CuentaAhorro(int numeroCuenta, double balance, double tasa):
    base(numeroCuenta, balance)
    {
        this.tasa = tasa;
        Console.WriteLine("Cuenta de Ahorro");
        Console.WriteLine("\nNo.: " + getNumeroCuenta());
        Console.WriteLine("Balance: " + balance);
        Console.ReadKey();
    }

    public void depositar(double deposito)
    {
        Console.WriteLine("\nProcesando deposito de... " + deposito);
        Console.ReadKey();
        setBalance(deposito);
        Console.WriteLine("Transaccion Realizada.");
        Console.WriteLine("Balance actual: " + getBalance());
    }

    public void retirar(double retiro)
    {
        Console.WriteLine("\nProcesando retiro de... " + retiro);
        Console.ReadKey();
        

        if(retiro > getBalance())
        {
            Console.WriteLine("\nEl monto a retirar es mayor que el balance.\n***RETIRO RECHAZADO***");
            Console.WriteLine("Solicitud: " + retiro);
            Console.WriteLine("Balance actual: " + getBalance());
        }
        else
        {
            setBalance(-retiro);
            Console.WriteLine("Transaccion Realizada.");
            Console.WriteLine("Balance actual: " + getBalance());
        }
    }

    public void interes()
    {
        Console.WriteLine("\nVerificando carga de intereses...");
        Console.ReadKey();
        

        if(fechaCarga != DateTime.Today)
        {
            setBalance(getBalance()*((tasa/360)));
            Console.WriteLine("Interes agregado. \nBalance: " + getBalance());
            fechaCarga = DateTime.Today;
        }
        else
        {
            Console.WriteLine("El interes diario se ha cargado anteriormente.\nProxima carga el " + (DateTime.Today.AddDays(1)));
        }
        Console.ReadKey();
    }

}

class CuentaCorriente : Cuenta
{
    private double sobregiro;

    public CuentaCorriente(int numeroCuenta, double balance, double sobregiro):
    base(numeroCuenta, balance)
    {
        this.sobregiro = sobregiro;
        Console.WriteLine("\nCuenta de Corriente");
        Console.WriteLine("\nNo.: " + getNumeroCuenta());
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Sobregiro: " + sobregiro);
        Console.ReadKey();
    }

    public void depositar(double deposito)
    {
        Console.WriteLine("\nProcesando deposito de ... " + deposito);
        Console.ReadKey();
        setBalance(deposito);
        Console.WriteLine("Transaccion Realizada.");
        Console.WriteLine("Balance actual: " + getBalance());
    }

    public double getSobregiro()
    {
        return (sobregiro + getBalance());
    }

    public void retirar(double retiro)
    {
        Console.WriteLine("\nProcesando retiro de... " + retiro);
        Console.ReadKey();
        

        if(retiro > (getBalance() + sobregiro))
        {
            Console.WriteLine("\nEl monto a retirar es mayor que el balance.\n***RETIRO RECHAZADO***");
            Console.WriteLine("Solicitud: " + retiro);
            Console.WriteLine("Balance actual: " + getBalance());
            Console.WriteLine("Sobregiro disponible: " + getSobregiro());
        }
        else
        {
            if(retiro <= getBalance())
            {
                setBalance(-retiro);
                Console.WriteLine("Transaccion Realizada.");
                Console.WriteLine("Balance actual: " + getBalance());
            }
            else
            {
                setBalance(-retiro);
                Console.WriteLine("Transaccion Realizada.");
                Console.WriteLine("Balance actual: " + getBalance());
                Console.WriteLine("Sobregiro disponible: " + getSobregiro());
            }
        }
    }

}


class Tester
{
    static void Main()
    {

        CuentaAhorro ca1 = new CuentaAhorro(45871, 0, 6.45);
        ca1.depositar(5000);
        ca1.depositar(7000);
        ca1.retirar(11000);
        ca1.retirar(2000);
        ca1.getNumeroCuenta();
        
        ca1.interes();
        ca1.interes();


        CuentaCorriente cc1 = new CuentaCorriente(1478569, 10000, 2000);
        cc1.depositar(2000);
        cc1.retirar(11500);
        cc1.retirar(1000);
        cc1.retirar(500);
        cc1.retirar(2000);


    }
}
