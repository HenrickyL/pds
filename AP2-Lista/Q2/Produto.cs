namespace Q2;
public class Produto
{
    public float Peso { get; private set; }
    public float Valor { get; private set; }

    public Produto(float peso, float valor) { 
        Peso = peso;
        Valor = valor;
    }
}
