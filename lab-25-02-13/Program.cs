public class Program{
    public static void Main(string[] args) {
        Start();
    }

    public static void Start() { 
        Onibus onibus = new Onibus();
        Aluno a1 = new Aluno(OnibusEstados.CHEGOU_1_PARADA);
        Aluno a2 = new Aluno(OnibusEstados.CHEGOU_1_PARADA);
        Aluno a3 = new Aluno(OnibusEstados.CHEGOU_2_PARADA);
        Aluno a4 = new Aluno(OnibusEstados.CHEGOU_3_PARADA);
        Prefeitura prefeitura = new Prefeitura();

        onibus.Attach(a1);
        onibus.Attach(a2);
        onibus.Attach(a3);
        onibus.Attach(a4);
        onibus.Attach(prefeitura);

        onibus.MudaEstado(OnibusEstados.CHEGOU_1_PARADA);
        onibus.MudaEstado(OnibusEstados.CHEGOU_2_PARADA);
        onibus.MudaEstado(OnibusEstados.CHEGOU_3_PARADA);
        onibus.MudaEstado(OnibusEstados.CHEGOU_UFC);
    }
}