public class Program{
    public static void Main(){
        Initialize();
    }

    public static void Initialize() { 
        VeiculoFabric fabric = new VeiculoFabric();

        List<IVeiculo> veiculos = new List<IVeiculo>();
        veiculos.Add(fabric.Get(VeiculoEnum.Carro));
        veiculos.Add(fabric.Get(VeiculoEnum.Moto));
        veiculos.Add(fabric.Get(VeiculoEnum.Caminhao));

        veiculos.ForEach(x => 
            Console.WriteLine(x.NumRodas())
        );
    }
}

