public class Program {
    public static void Main(string[] args) {
        Context context = new Context();

        IFrete frete = new FretePorPeso();

        context.SetFrete(frete);

        Pedido pedido = new Pedido();

        pedido.Add(new Produto(1.5f, 35f));
        pedido.Add(new Produto(7f, 45f));
        pedido.Add(new Produto(8.7f, 2.7f));
        pedido.Add(new Produto(9f, 120f));


        Console.WriteLine(context.CalculaFrete(pedido));
    }
}