namespace Q3.Strategy;
public class EspadaDuasMao : IArma
{
    public float GetDano()
    {
        return 100f;
    }

    public string GetVelocidade()
    {
        return "Lento";
    }
}
