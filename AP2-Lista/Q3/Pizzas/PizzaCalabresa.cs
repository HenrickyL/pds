using Q3.Propriedades;

namespace Q3.Pizzas;
public class PizzaCalabresa : APizza
{
    public PizzaCalabresa(PizzaProperty property) : base(property)
    {
    }

    public override void Preparar() { Console.WriteLine("Preparando pizza de Calabresa"); }
    public override void Assar() { Console.WriteLine("Assando pizza de Calabresa"); }
    public override void Cortar() { Console.WriteLine("Cortando pizza de Calabresa"); }
    public override void Embalar() { Console.WriteLine("Embalando pizza de Calabresa"); }
}
