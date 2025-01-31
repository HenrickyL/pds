public class Jogoteca  {
	public static void main(String[] args){
		Biblioteca biblioteca = new Biblioteca();
		UI ui = new UI(biblioteca);
		ui.mostrar();
	}
}
