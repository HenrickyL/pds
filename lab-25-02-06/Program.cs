public class Program{
    public static void Main(string[] args){
        IBebida bebida = new Cafe();
        Console.WriteLine($"{bebida.GetDescricao()} custa {bebida.Custo()}");

        bebida = new Leite(bebida);
        Console.WriteLine($"{bebida.GetDescricao()} custa {bebida.Custo()}");

        bebida = new Caramelo(bebida);
        Console.WriteLine($"{bebida.GetDescricao()} custa {bebida.Custo()}");
    }
}


// Interface para a bebida
public interface IBebida
{
    string GetDescricao();
    double Custo();
}

// Implementação de uma bebida concreta
public class Cafe : IBebida
{
    public string GetDescricao()
    {
        return "Café";
    }

    public double Custo()
    {
        return 3.0;
    }
}

// Classe base do decorator
public abstract class BebidaDecorator : IBebida
{
    protected IBebida bebida;

    public BebidaDecorator(IBebida bebida)
    {
        this.bebida = bebida;
    }

    public virtual string GetDescricao()
    {
        return bebida.GetDescricao();
    }

    public virtual double Custo()
    {
        return bebida.Custo();
    }
}

// Implementação de um decorator concreto
public class Leite : BebidaDecorator
{
    public Leite(IBebida bebida) : base(bebida) { }

    public override string GetDescricao()
    {
        return bebida.GetDescricao() + ", Leite";
    }

    public override double Custo()
    {
        return bebida.Custo() + 0.5;
    }
}

public class Caramelo : BebidaDecorator
{
    public Caramelo(IBebida bebida) : base(bebida) { }

    public override string GetDescricao()
    {
        return bebida.GetDescricao() + ", Caramelo";
    }

    public override double Custo()
    {
        return bebida.Custo() + 0.75;
    }
}

// Uso do Decorator Pattern
