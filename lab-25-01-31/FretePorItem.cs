public class FretePorItem : IFrete
{
    public float CalculaFrete(List<Produto> produtos)
    {
        return produtos.Count * 1.5f;
    }
}
