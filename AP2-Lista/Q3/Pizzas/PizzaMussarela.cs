using Q3.Propriedades;

namespace Q3.Pizzas;
public class PizzaMussarela : APizza
{
    public PizzaMussarela(PizzaProperty property) : base(property)
    {
    }

    public override void Preparar() { Console.WriteLine("Preparando pizza de mussarela"); }
    public override void Assar() { Console.WriteLine("Assando pizza de mussarela"); }
    public override void Cortar() { Console.WriteLine("Cortando pizza de mussarela"); }
    public override void Embalar() { Console.WriteLine("Embalando pizza de mussarela"); }
}
