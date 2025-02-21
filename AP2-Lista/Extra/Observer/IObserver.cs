using Extra.Subject;

namespace Extra.Observer;
public interface IObserver
{
    void Update(ISubject subject);
}
