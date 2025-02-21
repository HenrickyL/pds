using Q2.Decorator;
using Q2.Interfaces;
using Q2.Singleton;

namespace Q2.Fabric;
public static class BebidaFabric
{
    public static IBebida CriaCafe(TipoCafe tipo,List<TipoAdicional> adicionais, float valor) {
        IBebida result = null;
        switch (tipo) {
            case TipoCafe.Coado:
                result = new CafeCoado(valor);
                break;
            case TipoCafe.Expresso:
                result = new CafeExpresso(valor);
                break;
        }

        foreach(TipoAdicional adicional in adicionais)
        {
            result = GetAdicional(adicional, result);

        }
        Historico.Instance.CadastrarPedido(result);
        return result;
    }

    private static IBebida GetAdicional(TipoAdicional tipo, IBebida bebida) {
        IBebida result = null;
        switch (tipo)
        {
            case TipoAdicional.Chantili:
                result = new Chantili(bebida);
                break;
            case TipoAdicional.Ovomaltine:
                result = new Ovomaltine(bebida);
                break;
            case TipoAdicional.Chocolate:
                result = new Chocolate(bebida);
                break;
            case TipoAdicional.Creme:
                result = new Creme(bebida);
                break;
        }
        return result;
    }
}
