
namespace Q1.Subject;
public class Entregador : ASubject {
    //poderia ser uma lista de pedidos pra notificar todos
    public Pedido Pedido { get; private set; }
    public string Name { get; private set; }

    public Entregador(string name) { 
        Name = name;
    }

    public void RecebePedido(Pedido pedido) {
        this.Pedido = pedido;
        Attach(pedido.Cliente);
    }

    public void Entregar() {
        Notify();
    }

    public void ConfirmarRecebimento() {
        Pedido.ConfirmarEntrega();
    }
}
