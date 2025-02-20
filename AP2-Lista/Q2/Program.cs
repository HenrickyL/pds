using Q2.Interfaces;

namespace Q2 { 
    public class Program{
        public static void Main(string[] args){
            try
            {
                Start();
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }
        public static void Start() {
            List<Produto> produtos = new List<Produto>() {
                new Produto(1.5f,50f),
                new Produto(3f,50f),
                new Produto(12f,67.8f),
                new Produto(0.5f,20.5f),
                new Produto(8.8f,300f),
            };

            ICalculaFrete method1 = new CalculaFretePAC(20f);
            ICalculaFrete method2 = new CalculaFreteSedex(produtos, 0.4f);

            Context context = new Context(produtos, method1);

            context.DefineFrete();
            context.Metodo = method2;
            context.DefineFrete();


        }
    }
}