using Q2.Interfaces;

namespace Q2;
public class CalculaFreteSedex : ICalculaFrete
{
    public List<Produto> Produtos { get; set; }
    public float Taxa { get; set; }
    public CalculaFreteSedex(List<Produto> produtos, float taxa = 0.1f) {
        Produtos = produtos;
        Taxa = taxa;
    }
    public float CalculaFrete()
    {
        return Produtos.Aggregate(0f, (res, elem) => res + elem.Peso)*Taxa;
    }
}
