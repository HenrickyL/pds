using Q2.Interfaces;
namespace Q2.Decorator;
public abstract class BebidaDecorator : IBebida
{
    public IBebida bebida { get; set; }

    public BebidaDecorator(IBebida cafe)
    {
        bebida = cafe;
    }

    public virtual string GetDescricao()
    {
        return bebida.GetDescricao();
    }

    public virtual float GetValor()
    {
        return bebida.GetValor();
    }
}
