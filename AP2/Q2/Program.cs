using Q2.Fabric;
using Q2.Interfaces;
using Q2.Singleton;

namespace Q2;

public class Program
{
    public static void Main(string[] args) {
        try
        {
            Start();
        }
        catch (Exception ex) { 
            Console.WriteLine(ex.ToString());
        }
    }

    public static void Start() {
        List<TipoAdicional> adicionais1 = new() {
            TipoAdicional.Chocolate,
            TipoAdicional.Creme
        };
        List<TipoAdicional> adicionais2 = new() {
            TipoAdicional.Ovomaltine,
            TipoAdicional.Chantili,
            TipoAdicional.Chocolate,
        };

        IBebida pedido1 = BebidaFabric.CriaCafe(TipoCafe.Expresso,adicionais1, 8.5f);
        IBebida pedido2 = BebidaFabric.CriaCafe(TipoCafe.Coado, adicionais2, 12f);

        Historico.Instance.Relatorio();
    }
}