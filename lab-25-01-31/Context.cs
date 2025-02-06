public class Context
{
    private IFrete _frete;

    public void SetFrete(IFrete frete) { 
        this._frete = frete;
    }

    public float CalculaFrete(Pedido pedido) {
        return _frete.CalculaFrete(pedido.GetProdutos());
    }
}
