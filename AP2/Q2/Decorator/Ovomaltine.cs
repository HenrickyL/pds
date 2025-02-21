using Q2.Interfaces;

namespace Q2.Decorator;
public class Ovomaltine : BebidaDecorator
{
    public Ovomaltine(IBebida cafe) : base(cafe)
    {
    }

    public override string GetDescricao()
    {
        return base.GetDescricao() + "+ Ovomaltine";
    }

    public override float GetValor()
    {
        return base.GetValor() + 2.5f;
    }
}
