using Q5.Observer;

namespace Q5.Subject;
public class Padaria : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        observers.ForEach(o => { 
            o.Update();
        });
    }

    public void ProduzirNovaLeva() {
        Console.WriteLine("---------------");
        Console.WriteLine("Padaria: Produzindo nova leva.");
        Notify();
    }
}
