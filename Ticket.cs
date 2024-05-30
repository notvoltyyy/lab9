using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITicket
{
    void Buy();
}

public abstract class Ticket
{
    private int _id;
    private int _price;
    private bool _isValid;

    public int Id
    {
        get => _id;
        set { if (value > 10000 && value < 10100) { _id = value; } }
    }

    public int Price
    {
        get => _price;
        set { if (value > 0) { _price = value; } }
    }

    public bool IsValid
    {
        get => _isValid;
        set { _isValid = value; }
    }
}

public sealed class PlaneTicket : Ticket, ITicket
{
    private string from { get; set; }
    private string to { get; set; }
    private bool isVip { get; set; }

    public void Buy()
    {
        Console.WriteLine("")
    }

}

public sealed class BusTicket : Ticket, ITicket //make private fields, check constructors
{
    private string _code = "default";

    //private int _id;
   // private int _price;
    private int _type;        //1 - single use, 2 - multi use, maybe use bool
    private int _availableUses;
    //private bool _isValid;

    //public int Id
    //{
    //    get => _id;
    //    set { if(value > 10000 && value < 10100) { _id = value; } }
    //}

    public string Code
    {
        get => _code;
        set { _code = value; }
    }

    //public int Price
    //{
    //    get => _price;
    //    set { if (value > 0) { _price = value; } }
    //}

    public int Type
    {
        get => _type;
        set { if (value == 1 || value == 2) { _type = value; } }
    }

    public int AvailableUses
    {
        get => _availableUses;
        set { if (value >= 0) { _availableUses = value; } }
    }

    //public bool IsValid
    //{
    //    get => _isValid;
    //    set { _isValid = value; }
    //}

    public BusTicket()
    {
        Random rng = new Random();
        Price = 10;
        Type = 1;
        IsValid = false;
        AvailableUses = 1;
        Id = 10000 + rng.Next(1, 100);
    }

    public BusTicket(int type)
    {

        IsValid = false;

        if (type == 1)
        {
            AvailableUses = 1;
            Price = 10;
        }
        else if (type == 2)
        {
            AvailableUses = 5;
            Price = 50;

        }
        else
        {
            Console.WriteLine("Invalid ticket type."); //not sure if it is suitable 
        }
        this.Type = type;
        IsValid = false;
        Random rng = new Random();
        Id = 10000 + rng.Next(1, 100);
    }
    public BusTicket(int price, int type, bool isValid, int availbleUses)
    {

        this.Price = price;
        this.Type = type;
        this.IsValid = isValid;
        this.AvailableUses = availbleUses;

    }

    public void Buy()
    {
        Console.WriteLine("Input type (1 - Single Use (10 Uah), 2 - Multiuse(5 uses, 50 uah): ");
        Type = Convert.ToInt32(Console.ReadLine());
    }

    //public void Input()
    //{
    //    Console.WriteLine("Input id: ");
    //    Id = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Input price: ");
    //    Price = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Input type(1/2): ");
    //    Type = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Input available uses: ");
    //    AvailableUses = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Input validation state");
    //    IsValid = Convert.ToBoolean(Console.ReadLine()); //?
    //    Console.WriteLine("Input code: ");
    //    Code = Console.ReadLine();
    //}

    public override string ToString()
    {
        return "Id: " + Id + ", type: " + Type + ", price: " + Price + ", available uses: " + AvailableUses + ", is valid: " + IsValid.ToString();
    }
}