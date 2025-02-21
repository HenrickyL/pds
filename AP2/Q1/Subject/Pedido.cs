using Q1.interfaces;
using Q1.Observer;

namespace Q1.Subject;
public class Pedido : ASubject, IPedido
{
    public string Id { get; set; }
    public Entregador Entregador { get; set; }
    public Cliente Cliente { get; set; }
    public Restaurante Restaurante { get; set; }
    public float Valor { get; set; }

    public Pedido(string id, Restaurante restaurante, Cliente cliente, float valor) 
    {
        Id = id;
        Cliente = cliente;
        Restaurante = restaurante;
        Valor = valor;
        Attach(Restaurante);
        Attach(Cliente);
    }

    public void ConfirmarEntrega()
    {
        this.Notify();
    }
}
