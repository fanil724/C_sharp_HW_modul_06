namespace C_sharp_HW_modul_06;

public abstract class Worker
{
    public abstract void print();
}

class President : Worker
{
    public override void print()
    {
        Console.WriteLine("I am president.");
    }
}

class Security : Worker
{
    public override void print()
    {
        Console.WriteLine("I am security.");
    }
}

class Manager : Worker
{
    public override void print()
    {
        Console.WriteLine("I am manager.");
    }
}

class Engineer : Worker
{
    public override void print()
    {
        Console.WriteLine("I am engineer.");
    }
}