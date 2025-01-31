
public abstract class Veiculo implements IVeiculo{
	protected String chassi;
	private int qtdRodas;
	
	public Veiculo(String chassi, int qtdRodas){
		this.chassi = chassi;
		this.qtdRodas = qtdRodas;
	}

    public int getNumeroRodas(){
		return qtdRodas;
	}


}
