using Q1.Subject;

namespace Q1.Observer;
public interface IObserver
{
    public void Update(ISubject subject);
}
