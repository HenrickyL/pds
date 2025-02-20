public class Aluno : IObserver
{
    public string Name { get; private set; }
    public List<Nota> Notas { get; private set; }

    public Aluno(string name){
        Name = name;
        Notas = new List<Nota>();
    }

    public void Update(ISubject subject)
    {
        if(subject is Turma){
            Turma turma = (Turma)subject;
            Console.WriteLine($"Aluno `{Name}` recebeu notificação da nota na turma `{turma.Name}`.");
        }
    }
}