using Q3.Interfaces;
using Q3.Pizzas;
using Q3.Propriedades;

namespace Q3.Fabrics;
public class CalabresaFabric : IPizzaFactory
{
    public IPizza CriaPizza(PizzaProperty property)
    {
        return new PizzaCalabresa(property);
    }
}
