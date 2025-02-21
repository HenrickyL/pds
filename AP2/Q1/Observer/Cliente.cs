using Q1.Subject;

namespace Q1.Observer;
public class Cliente : IObserver
{
    //getter e setter
    public string Name { get; private set; }

    public Cliente(string name)
    {
        Name = name;
    }

    public void Update(ISubject subject)
    {
        if (subject is Entregador) {
            Entregador entregador = (Entregador)subject;
            Console.WriteLine($"> [{Name}] Seu pedido {entregador.Pedido.Id} do restaurante {Entregador.}");
        } else if (subject is Pedido) { 
            Pedido pedido = (Pedido)subject;
            Console.WriteLine($"[{Name}] Seu pedido {pedido.Id} foi entregue");
        }
    }
}
