using Extra.Observer;

namespace Extra.Subject;
public class ASubject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        _observers.ForEach(o => {
            o.Update(this);
        });
    }
}
