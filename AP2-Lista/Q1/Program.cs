public class Program
{
    public static void Main()
    {
        try{
            Start();
        }catch(Exception e){
            Console.Error.WriteLine(e.ToString());
        }
    }

    public static void Start(){
        Coordenador coordenador = new Coordenador();

        Sistema sistema = new Sistema(coordenador);

        Professor professor = new Professor();

        sistema.CriarTurma("Matemática", professor);

        Aluno aluno1 = new Aluno("João");
        Aluno aluno2 = new Aluno("Maria");

        Turma turmaMatematica = sistema.Turmas[0]; // Pega a primeira turma criada
        turmaMatematica.AddAluno(aluno1);
        turmaMatematica.AddAluno(aluno2);

        List<(Aluno, float)> notas = new List<(Aluno, float)>
        {
            (aluno1, 8.5f),
            (aluno2, 9.0f)
        };

        sistema.CadastrarNotas(professor, turmaMatematica, notas);
    }
}