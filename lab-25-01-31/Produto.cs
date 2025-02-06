public  class Produto
{
    public float Peso { get; private set; }
    public float Preco { get; private set; }

    public Produto(float peso, float preco)
    {
        Peso = peso;
        Preco = preco;
    }
}
