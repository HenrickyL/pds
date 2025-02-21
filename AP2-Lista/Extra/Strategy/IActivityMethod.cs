using Extra.Observer;

namespace Extra.Strategy;
public interface IActivityMethod
{
    void SendNotification(User user, string message);
}
