import java.util.ArrayList;

public class Biblioteca {
    private ArrayList<Jogo> repositorioJogos;

    public Biblioteca() {
        repositorioJogos = new ArrayList<Jogo>();
    }

    public void adicionarJogo(String titulo, String descricao) {
        repositorioJogos.add(new Jogo(titulo, descricao));
    }

}
