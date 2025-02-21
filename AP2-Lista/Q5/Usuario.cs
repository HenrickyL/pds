using Q5.Observer;

namespace Q5;
public class Usuario : IObserver
{
    public string Name { get; set; }

    public Usuario(string name) { 
        Name = name;
    }
    public void Update()
    {
        Console.WriteLine($"Notificando `{Name}` que saiu pão quentinho.");
    }
}
