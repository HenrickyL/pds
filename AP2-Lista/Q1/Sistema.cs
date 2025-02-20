public class Sistema{
    public List<Turma> Turmas {get; set;}
    private Coordenador _coordenador;

    public Sistema(Coordenador coordenador){
        Turmas = new List<Turma>();
        _coordenador = coordenador;
    }

    public void CadastrarNotas(Professor professor, Turma turma, List<(Aluno, float)> notas){
        turma.CadastrarNotas(professor, notas);
    }

    public void CriarTurma(string nome, Professor professor){
        Turma turma= new Turma(nome, professor);
        turma.Attach(_coordenador);
        Turmas.Add(turma);
    }
}