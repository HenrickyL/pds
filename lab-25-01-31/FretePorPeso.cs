public class FretePorPeso : IFrete
{
    public float CalculaFrete(List<Produto> produtos)
    {
        return produtos.Aggregate(0f, (sum, next) => sum + next.Peso);
    }
}
