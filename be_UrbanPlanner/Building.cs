using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_UrbanPlanner
{
  class Building
  {
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; } 
    public double Volume { get; private set; }

    string _designer; // will hold your name
    DateTime _dateConstructed; // when was the building created
    string _address; 
    string _owner;  // this will store the name of the person that owns the building

    public Building(string address)
    {
      _designer = "onlyJuan";
      _address = address;
      _dateConstructed = DateTime.Now;
    }

    public void Purchase(string owner)
    {
      _owner = owner;
    }

  public void SetValue()
    {
      Volume = Width * Depth * (3 * Stories);
    }

    public void PrintBuilding()
    {
      Console.WriteLine(String.IsNullOrWhiteSpace(_address) ? "" : $"\n\nBuilding address; {_address}");
      Console.WriteLine(String.IsNullOrWhiteSpace(_designer) ? "" : $"Designed by; {_designer}");
      Console.WriteLine($"Constructed on ; {_dateConstructed}");
      Console.WriteLine(String.IsNullOrWhiteSpace(_owner) ? "" : $"Owner by: {_owner}");
      Console.WriteLine($"{Volume} cubic meters of space");
    }


  }
}
