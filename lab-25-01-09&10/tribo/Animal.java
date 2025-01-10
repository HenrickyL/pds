import java.util.ArrayList;
import java.util.Iterator;

public class Animal {
	private String nome; 
	private String especie; 
	public Animal(String aEspecie, String aNome) 
	{ 
		especie = aEspecie; 
		nome = aNome; 
	} 
	public String getEspecie() { 
		return especie; 
	} 
	public boolean estouNestaTribo(Tribo tribo){ 
		ArrayList<Animal> animais = tribo.getAnimais(); 
		boolean achou=false; 
		Iterator<Animal> it = animais.iterator(); 
		while ((it.hasNext()) && (!achou)){ 
			if (it.next().equals(this)){ 
				achou = true; 
			} 
		} 
		return achou; 
	} 
	public boolean equals(Object obj){ 
		Animal a = (Animal) obj; 
		if  
		((this.nome.equalsIgnoreCase(a.nome)) && 
				(this
						.especie.equalsIgnoreCase(a.especie))){ 
			return true; 
		} 
		return false; 
	} 
	public String getNome() { 
		return nome; 
	} 
	public void setNome(String nome) { 
		this.nome = nome; 
	} 
}
