public class Gerente extends Funcionario {
    public Gerente(String nome, Locadora locadora) {
        super(nome, locadora);
    }
    
    public void adicionaVeiculoNaFrota(String modelo, VeiculoEnum tipo){
        locadora.addVeiculo(modelo,tipo);
    }
}
