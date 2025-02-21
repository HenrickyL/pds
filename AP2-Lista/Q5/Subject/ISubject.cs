using Q5.Observer;

namespace Q5.Subject;
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
