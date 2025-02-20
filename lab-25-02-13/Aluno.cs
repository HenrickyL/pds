public class Aluno : IObserver
{
    private OnibusEstados _parada = OnibusEstados.CHEGOU_1_PARADA;


    public Aluno(OnibusEstados parada)
    {
        _parada = parada;
    }

    public void Update(ISubject subject)
    {
        Onibus onibus = (Onibus)subject;
        if (onibus != null)
        {
            if(_parada == onibus.Estado)
                Console.WriteLine("Perdi o Onibus");
            else
                Console.WriteLine("Peguei o Onibus");
        }
    }

    public void SetParada(OnibusEstados parada) { 
        _parada = parada;
    }
}
