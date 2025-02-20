using Q2.Interfaces;
namespace Q2 {
    public class CalculaFretePAC : ICalculaFrete
    {
        public float ValorFixo { get; private set; }

        public CalculaFretePAC(float valorFixo)
        {
            ValorFixo = valorFixo;
        }

        public float CalculaFrete()
        {
            return ValorFixo;
        }
    }
}