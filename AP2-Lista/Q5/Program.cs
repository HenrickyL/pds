using Q5.Subject;

namespace Q5;
public class Program {
    public static void Main(string[] args) {
        try
        {
            Start();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }


    public static void Start() {
        Usuario u1 = new Usuario("Henricky");
        Usuario u2 = new Usuario("Luis");
        Usuario u3 = new Usuario("Andreina");
        Usuario u4 = new Usuario("Almir");
        Usuario u5 = new Usuario("Dheymisson");


        Padaria padaria = new Padaria();
        padaria.Attach(u1);
        padaria.Attach(u2);
        padaria.ProduzirNovaLeva();
        padaria.Attach(u3);
        padaria.Attach(u4);
        padaria.Attach(u5);
        padaria.ProduzirNovaLeva();
    }
}