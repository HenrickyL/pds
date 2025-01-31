public class Botao implements IAcionador {
    IAparelho aparelho;
    boolean ligado = false;
    public Botao(IAparelho aparelho) {
        this.aparelho = aparelho;
    }
    @Override
    public void acionar() {
        if(ligado){
            aparelho.desligar();
        }else{
            aparelho.ligar();
        }
        ligado = !ligado;
    }
}
