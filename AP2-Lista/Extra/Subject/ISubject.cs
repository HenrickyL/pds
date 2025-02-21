using Extra.Observer;

namespace Extra.Subject;
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
