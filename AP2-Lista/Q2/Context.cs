using Q2.Interfaces;

namespace Q2;
public class Context
{
    public ICalculaFrete Metodo { get; set; }
    public List<Produto> Produtos { get; set; }
    public Context(List<Produto> produtos, ICalculaFrete calculaFreteMetodo)
    {
        Metodo = calculaFreteMetodo;
        Produtos = produtos;
    }

    public void DefineFrete() {
        float frete = Metodo.CalculaFrete();
        Console.WriteLine($"O Frete é R${frete}.");
    }
}
