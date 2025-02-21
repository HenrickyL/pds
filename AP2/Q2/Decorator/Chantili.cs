using Q2.Interfaces;

namespace Q2.Decorator;
public class Chantili : BebidaDecorator
{
    public Chantili(IBebida cafe) : base(cafe)
    {
    }

    public override string GetDescricao()
    {
        return base.GetDescricao() + "+ Chantili";
    }

    public override float GetValor()
    {
        return base.GetValor() + 0.5f;
    }
}
