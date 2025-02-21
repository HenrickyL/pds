using Q1.Subject;

namespace Q1.Observer;
public class Restaurante : IObserver
{
    public string Name { get; set; }
    public void Update(ISubject subject)
    {
        if (subject is Pedido) { 
            Pedido pedido = (Pedido)subject;
            Console.WriteLine($"> [{this.Name}] Pedido {pedido.Id} do restaurante recebido pelo cliente {pedido.Cliente.Name}.");
        }
    }
}
