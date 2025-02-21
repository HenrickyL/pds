namespace Q2;
public class CafeExpresso : Cafe
{
    public CafeExpresso(float valor) : base(valor)
    {
    }

    public override string GetDescricao()
    {
        return "Cafe Expresso";
    }
}
