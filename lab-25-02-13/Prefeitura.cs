public class Prefeitura : IObserver
{
    Dictionary<Onibus, int> _dictionary;
    public Prefeitura()
    {
        _dictionary  = new Dictionary<Onibus, int>();
    }

    public void Update(ISubject subject)
    {
        Onibus onibus = (Onibus)subject;
        if (onibus != null) {
            if (!_dictionary.ContainsKey(onibus))
            {
                _dictionary.Add(onibus, 0);
            }
            
            if (onibus.Estado == OnibusEstados.CHEGOU_UFC)
            {
                _dictionary[onibus] += 1;
                Console.WriteLine($"Pagar {_dictionary[onibus]} ao motorista do onibus");
            }
        }
    }
}
