namespace C_sharp_HW_modul_06;

public abstract class Device
{
    public Device(string name, string voice, string description)
    {
        _voice = voice;
        _name = name;
        _description = description;
    }

    public void Sound()
    {
        Console.WriteLine(_voice);
    }

    public void Show()
    {
        Console.WriteLine(_name);
    }

    public void Desc()
    {
        Console.WriteLine(_description);
    }

    public string _voice { get; set; }
    public string _name { get; set; }
    public string _description { get; set; }

    public void print()
    {
        Show();
        Sound();
        Desc();
    }
}

class Kettle : Device
{
    public Kettle(string name, string voice, string description)
    :base(name,voice,description)
    {
    }
}
class Microwave : Device
{
    public Microwave(string name, string voice, string description)
        :base(name,voice,description)
    {
    }
}
class Car : Device
{
    public Car(string name, string voice, string description)
        :base(name,voice,description)
    {
    }
}
class Steamboat : Device
{
    public Steamboat(string name, string voice, string description)
        :base(name,voice,description)
    {
    }
}