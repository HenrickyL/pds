public class Lampada implements IAparelho {
    @Override
    public void ligar() {
        System.out.println("Lampada ligada");
    }

    @Override
    public void desligar() {
        System.out.println("Lampada Desligada");
    }
}
