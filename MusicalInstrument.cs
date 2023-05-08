namespace C_sharp_HW_modul_06;

public class MusicalInstrument
{
    
    public MusicalInstrument(string name, string voice, string description,string hustoryInstrument)
    {
        _voice = voice;
        _name = name;
        _description = description;
        _hustoryInstrument = hustoryInstrument;
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

    public void History()
    {
        Console.WriteLine(_hustoryInstrument);
    }

    public string _voice { get; set; }
    public string _name { get; set; }
    public string _description { get; set; }
    public string _hustoryInstrument { get; set; }

    public void print()
    {
        Show();
        Sound();
        Desc();
        History();
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string voice, string description,string hustoryInstrument)
        :base(name,voice,description,hustoryInstrument)
    {
    }
}
class Trombone : MusicalInstrument
{
    public Trombone(string name, string voice, string description,string hustoryInstrument)
        :base(name,voice,description,hustoryInstrument)
    {
    }
}
class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string voice, string description,string hustoryInstrument)
        :base(name,voice,description,hustoryInstrument)
    {
    }
}
class Cello : MusicalInstrument
{
    public Cello(string name, string voice, string description,string hustoryInstrument)
        :base(name,voice,description,hustoryInstrument)
    {
    }
}