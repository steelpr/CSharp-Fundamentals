public abstract class Data : IIformation
{
    public Data(string name, string date)
    {
        Name = name;
        Birthdate = date;
    }

    public string Name { get; set; }

    public string Birthdate { get; set; }
}
