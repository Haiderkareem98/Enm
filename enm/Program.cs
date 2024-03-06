


haider Haider = new haider();
Haider.fullName = "Haider kareem";
Haider.Age = 26;
Haider.Country = Country.Bagdad;

Console.WriteLine($"{Haider.fullName}, {Haider.Age}, {Haider.Country}") ;




haider Haider1=new haider("haider2",66,Country.spain);
Console.WriteLine($"{Haider1.fullName}, {Haider1.Age}, {Haider1.Country}");

// استدعاء عادي

Console.WriteLine(Country.canada);
public enum Country
{
    Bagdad,
    Egypt,
    Usa,
    canada,
    spain,
}


 public class haider
{
    public string fullName { get; set; }
    public int Age { get; set; }
    public Country Country { get; set; }

    public haider() { }

    public haider(string ful,int ag,Country cou) 
    { 
        fullName = ful;
        Age = ag;
        Country = cou;
    }

}