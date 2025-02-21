using Q3.Interfaces;
using Q3.Propriedades;

namespace Q3;
public class Pizzaria
{
    private IPizzaFactory factory;

    public Pizzaria(IPizzaFactory factory)
    {
        this.factory = factory;
    }

    public void SetPizzaFactory(IPizzaFactory factory) {
        this.factory = factory;
    }

    public void FazerPizza(PizzaProperty property)
    {
        IPizza pizza = this.factory.CriaPizza(property);
        Console.WriteLine("-----------");
        pizza.Preparar();
        pizza.Assar();
        pizza.Cortar();
        pizza.Embalar();
        pizza.Detalhe();
    }
}
