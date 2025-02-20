public class Turma : ASubject{
    private List<Aluno> _alunos;
    private Professor _professor;
    public string Name { get; private set; }

    public Turma(string name, Professor professor){
        Name = name;
        _alunos = new List<Aluno>();
        _professor = professor;
    }

    public void AddAluno(Aluno aluno){
        _alunos.Add(aluno);
        Attach(aluno);
    }

    public void CadastrarNotas(Professor professor, List<(Aluno, float)> notas){
        if(professor != _professor) throw new Exception("Esse professor não leciona nesta turma.");
        foreach(var (aluno, nota) in notas){
            if(!_alunos.Contains(aluno)) throw new Exception("Esse aluno não pertence a turma!");
            Nota currentNota = new Nota(professor,this, aluno, nota);
            aluno.Notas.Add(currentNota);
        }
        Notify();
    }
}