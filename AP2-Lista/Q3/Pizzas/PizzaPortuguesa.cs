using Q3.Propriedades;

namespace Q3.Pizzas;
public class PizzaPortuguesa : APizza
{
    public PizzaPortuguesa(PizzaProperty property) : base(property)
    {
    }

    public override void Preparar() { Console.WriteLine("Preparando pizza de Portuguesa"); }
    public override void Assar() { Console.WriteLine("Assando pizza de Portuguesa"); }
    public override void Cortar() { Console.WriteLine("Cortando pizza de Portuguesa"); }
    public override void Embalar() { Console.WriteLine("Embalando pizza de Portuguesa"); }
}
