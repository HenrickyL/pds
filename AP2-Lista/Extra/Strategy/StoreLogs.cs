using Extra.Observer;
using Extra.Singleton;

namespace Extra.Strategy;
public class StoreLogs : IActivityMethod
{
    public void SendNotification(User user, string message)
    {
        StoreLogsManager.Instance.AddLog(user, message);
    }
}
