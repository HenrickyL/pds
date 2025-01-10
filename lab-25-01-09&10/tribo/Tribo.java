import java.util.ArrayList;

public class Tribo {
	private ArrayList<Animal> animais; 
	private ArrayList<Indio> indios; 
	private Cacique cacique; 
	public Tribo() { 
		animais = new ArrayList<Animal>(); 
	} 
	public void adicionaAnimal(Animal animal) { 
		animais.add(animal); 
	} 
	public int getNumPatas() { 
		int result = 0; 
		for (Animal a : animais) { 
			if (a.getEspecie().equals("Pato")) { 
				result += 2; 
			} else if (a.getEspecie().equals("Cachorro")) { 
				result += 4; 
			} else { 
				// ? 
			} 
		} 
		return result; 
	} 
	public ArrayList<Animal> getAnimais() { 
		return animais; 
	} 
	public void setAnimais(ArrayList<Animal> 
	animais) { 
		this.animais = animais; 
	} 
	public void removeAnimal(Animal animal) { 
		this.animais.remove(animal); 
	} 
	public void addIndio(Indio indio) { 
		this.indios.add(indio); 
	} 
	public ArrayList<Indio> getIndios() { 
		return indios; 
	} 
	public void setCacique(Cacique cacique) { 
		this.cacique = cacique; 
	} 
	public Cacique getCacique() { 
		return this.cacique; 
	} 
}
