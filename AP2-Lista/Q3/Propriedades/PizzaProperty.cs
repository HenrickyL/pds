using Q3.Enums;

namespace Q3.Propriedades;
public record class PizzaProperty
{
    public TipoBorda TipoBorda { get; set; }
    public TipoMassa TipoMassa { get; set; }
    public Tamanho Tamanho { get; set; }
}
