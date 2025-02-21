using Q2.Interfaces;

namespace Q2.Decorator;
public class Creme : BebidaDecorator
{
    public Creme(IBebida cafe) : base(cafe)
    {
    }

    public override string GetDescricao()
    {
        return base.GetDescricao() + "+ Cheme";
    }

    public override float GetValor()
    {
        return base.GetValor() + 1.5f;
    }
}
