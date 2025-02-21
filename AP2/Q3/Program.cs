using Q3.Strategy;

namespace Q3;

public class Program {
    public static void Main(string[] args) {
        Start();
    }

    public static void Start() { 
        IArma arma1 = new EspadaDuasMao();
        IArma arma2 = new EspadaUmaMao();

        Guerreira guerreira = new Guerreira(arma1);
        guerreira.Atacar();
        guerreira.TrocaArma(arma2);
        guerreira.Atacar();
    }
}