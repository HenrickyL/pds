using Q2.Interfaces;

namespace Q2.Singleton;
public class Historico
{
    private static Historico _instance;
    public static Historico Instance {
        get { 
            if(_instance == null) _instance = new Historico();
            return _instance;
        }
    }

    private List<IBebida> bebidas = new List<IBebida>();
    private Historico() { }

    public void CadastrarPedido(IBebida bebida) {
        bebidas.Add(bebida);
    }

    public void Relatorio() {
        Console.WriteLine("----------Relatorio-------------");
        bebidas.ForEach(b => { 
            Console.WriteLine($"> Bebida: {b.GetDescricao()} - Valor: {b.GetValor()}");
        });

    }
}
