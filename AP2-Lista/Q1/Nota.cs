public class Nota{
    public Professor Professor { get; private set; }
    public Aluno Aluno { get; private set; }
    public Turma Turma { get; private set; }

    public float Valor { get; private set; }

    public Nota(Professor p, Turma t, Aluno a, float valor){
        Professor = p;
        Aluno = a;
        Turma = t;
        Valor = valor;
    }
}