public class Pedido
{
    private List<Produto> _produtos;

    public Pedido() {
        _produtos = new List<Produto>();
    }
    public void Add(Produto produto) { 
        _produtos.Add(produto);
    }

    public List<Produto> GetProdutos() { return _produtos; }
}
