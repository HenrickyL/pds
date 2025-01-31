import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

@SuppressWarnings("serial")
public class UI  extends JFrame implements ActionListener{
    JButton adicionar;
	JTextField titulo;
	JTextArea corpo;

    Biblioteca biblioteca;

    public UI(Biblioteca biblioteca){
        this.biblioteca = biblioteca;

        titulo = new JTextField("Digite o titulo...");
		this.add(titulo,BorderLayout.NORTH);
		corpo = new JTextArea("Descricao do jogo...");
		this.add(corpo,BorderLayout.CENTER);
		adicionar = new JButton("Adicionar Jogo");
		adicionar.addActionListener(this);
		this.add(adicionar,BorderLayout.SOUTH);
    }

    public void mostrar() {
		this.setSize(400,400);
		this.setLocation(100, 100);
		this.setVisible(true);
	}

    @Override
	public void actionPerformed(ActionEvent publicarPost) {
		this.biblioteca.adicionarJogo(this.titulo.getText(), this.corpo.getText()); 
	}
}
