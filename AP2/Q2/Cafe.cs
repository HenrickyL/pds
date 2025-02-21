using Q2.Interfaces;

namespace Q2;
public abstract class Cafe : IBebida
{
    private float valor;

    public Cafe(float valor) {
        this.valor = valor;
    }
    public abstract string GetDescricao(); //metodo virtual

    public float GetValor() { 
        return valor;
    }
}
