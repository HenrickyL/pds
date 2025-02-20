public class Coordenador : IObserver
{
    public void Update(ISubject subject)
    {
        if(subject is Turma){
            Turma t = (Turma)subject;
            Console.WriteLine($"Atualização das notas da Turma {t.Name}.");
        }
    }
}