namespace Q4;
public class Usuario
{
    private static int idCount= 0;
    public int Id { get; private set; }
    public string Name { get; set; }

    public Usuario(string name)
    {
        Name = name;
        Id = ++idCount;
    }

    public override string ToString()
    {
        return $"> ID: {Id} - NAME: {Name}";
    }
}
