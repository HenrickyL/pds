using Q3.Enums;
using Q3.Interfaces;
using Q3.Propriedades;

namespace Q3;
public abstract class APizza : IPizza
{
    public  Tamanho Tamanho { get; protected set; }
    public TipoBorda TipoBorda { get; protected set; }
    public TipoMassa TipoMassa { get; protected set; }

    public APizza(PizzaProperty property)
    {
        TipoMassa = property.TipoMassa;
        TipoBorda = property.TipoBorda;
        Tamanho = property.Tamanho;
    }

    public abstract void Assar();
    public abstract void Cortar();
    public abstract void Embalar();
    public abstract void Preparar();

    public void Detalhe()
    {
        Console.WriteLine($"Detalhes:\nMassa: {TipoMassa}, Borda: {TipoBorda}, Tamanho: {Tamanho}");
    }
}

