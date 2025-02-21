using Q2.Interfaces;

namespace Q2.Decorator;
public class Chocolate : BebidaDecorator
{
    public Chocolate(IBebida cafe) : base(cafe)
    {
    }

    public override string GetDescricao()
    {
        return base.GetDescricao() + "+ Chocolate";
    }

    public override float GetValor()
    {
        return base.GetValor() + 2f;
    }
}
