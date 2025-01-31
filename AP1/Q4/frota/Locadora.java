public class Locadora {
    private Frota frota;
    public Locadora(Frota frota){
        this.frota = frota;
    }

    public int getQuantidadeDeVeiculos() {
        return frota.getNumeroVeiculos();
    }

    public int getNumeroRodas() {
        return frota.getNumeroRodas();
    }

    public void addVeiculo(String modelo, VeiculoEnum tipo){
        Veiculo toAdd;
        switch (tipo) {
            case Carro:
                toAdd = new Carro(modelo);
                frota.adicionaVeiculo(toAdd);
                break;
            case Moto:
                toAdd = new Moto(modelo);
                frota.adicionaVeiculo(toAdd);
                break;
            case Caminhao:
                toAdd = new Caminhao(modelo);
                frota.adicionaVeiculo(toAdd);
                break;
            default:
                break;
        }
    }
}
