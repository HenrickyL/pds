using Q3.Enums;
using Q3.Fabrics;
using Q3.Interfaces;
using Q3.Pizzas;
using Q3.Propriedades;

namespace Q3 {
    public class Program {
        public static void Main(string[] args)
        {
            try
            {
                Start();
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }
        public static void Start() {
            PizzaProperty pizza1Prop = new PizzaProperty() { 
                Tamanho = Tamanho.Pequena,
                TipoBorda = TipoBorda.Normal,
                TipoMassa = TipoMassa.Fina
            };
            PizzaProperty pizza2Prop = new PizzaProperty()
            {
                Tamanho = Tamanho.Media,
                TipoBorda = TipoBorda.Recheada,
                TipoMassa = TipoMassa.Grossa
            }; PizzaProperty pizza3Prop = new PizzaProperty()
            {
                Tamanho = Tamanho.Grande,
                TipoBorda = TipoBorda.Normal,
                TipoMassa = TipoMassa.Normal
            };


            //fabric
            IPizzaFactory factoryCalabresa = new CalabresaFabric();
            IPizzaFactory factoryMussarela = new MussarelaFabric();
            IPizzaFactory factoryPortuguesa = new PortuguesaFabric();


            //pizzaria
            Pizzaria pizzaria = new Pizzaria(factoryCalabresa);
            pizzaria.FazerPizza(pizza1Prop);
            pizzaria.SetPizzaFactory(factoryMussarela);
            pizzaria.FazerPizza(pizza2Prop);
            pizzaria.SetPizzaFactory(factoryPortuguesa);
            pizzaria.FazerPizza(pizza3Prop);
        }
    }
}