public class VeiculoFabric : IFabric
{
    public IVeiculo Get(VeiculoEnum type)
    {
        IVeiculo veiculo = null;
        switch (type) {
            case VeiculoEnum.Carro:
                veiculo = new Carro();
                break;
            case VeiculoEnum.Moto:
                veiculo = new Moto();
                break;
            case VeiculoEnum.Caminhao:
                veiculo= new Caminhao();
                break;
            default:
                throw new Exception("Invalid Type");
        }
        return veiculo;
    }
}