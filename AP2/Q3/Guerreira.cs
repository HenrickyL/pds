using Q3.Strategy;

namespace Q3;
public class Guerreira
{
    private IArma arma;

    public Guerreira(IArma arma) { 
        this.arma = arma;
    }

    public void TrocaArma(IArma arma) {
        this.arma = arma;
    }

    public void Atacar() { 
        Console.WriteLine($"> Guerreira deu um {arma.GetVelocidade()} causando {arma.GetDano()} de dano.");
    }
}
