using Q1.Observer;

namespace Q1.Subject;
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
