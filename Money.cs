namespace C_sharp_HW_modul_06;

public class Money
{
    public Money(string name, UInt32 whole, UInt32 fractional)
    {
        _name = name;
        _whole = whole;
        _fractional = fractional;
    }

    public void print()
    {
        Console.WriteLine(_whole + $",{_fractional}" + $" {_name}");
    }

    public string _name { get; set; }
    public UInt32 _whole { get; set; }
    public UInt32 _fractional { get; set; }
}

class Product
{
    public Product(string nameproduct, string name, UInt32 whole, UInt32 fractional)
    {
        _nameProduct = nameproduct;
        _price = new Money(name, whole, fractional);
    }

    public Product(string nameproduct, Money money)
    {
        _nameProduct = nameproduct;
        _price = money;
    }

    public static Product operator -(Product product, double summa)
    {
        product._price._whole -= (uint)summa / 1;
        product._price._fractional -= (uint)(summa % 1*100);
        return product;
    }

    public void print()
    {
        Console.WriteLine(_nameProduct);
        _price.print();
    }

    public string _nameProduct { get; set; }
    private Money _price;
}