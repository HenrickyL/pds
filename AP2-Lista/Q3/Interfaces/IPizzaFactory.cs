using Q3.Propriedades;

namespace Q3.Interfaces;
public interface IPizzaFactory
{
    IPizza CriaPizza(PizzaProperty property);
}
