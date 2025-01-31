import java.util.ArrayList;

public class Frota {
	private ArrayList<IVeiculo> veiculos;
	
	public Frota() {
		veiculos = new ArrayList<IVeiculo>();
	}
	
	public int getNumeroRodas() {
		int rodas = 0;
		for (IVeiculo v: veiculos) {
			rodas += v.getNumeroRodas();
		}
		return rodas;
	}

	public void adicionaVeiculo(Veiculo v) {
		this.veiculos.add(v);
	}

	public int getNumeroVeiculos() {
		return veiculos.size();
	}
	public void adicionaVeiculo(IVeiculo v){
		this.veiculos.add(v);
	}
}
