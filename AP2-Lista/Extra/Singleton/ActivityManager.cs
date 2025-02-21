using Extra.Enums;
using Extra.Observer;
using Extra.Strategy;
using Extra.Subject;

namespace Extra.Singleton;
public class ActivityManager
{
    private static ActivityManager _instance;
    public static ActivityManager Instance {
        get { 
            if(_instance == null) _instance = new ActivityManager();
            return _instance;
        }
    }

    IActivityMethod _activityMethod;
    private ActivityManager() { }

    private void SetActivityPriority(Priority priority) {
        switch (priority) { 
            case Priority.Low:
                _activityMethod = new StoreLogs();
                break;
            case Priority.Medium:
                _activityMethod = new SmsNotification();
                break;
            case Priority.High:
                _activityMethod = new MailNotification();
                break;
            default:
                throw new Exception("Invalid priority type");
        }
    }

    public Activity CreateActivity(string title, Priority priority) {
        Activity activity = new Activity(title, priority);
        return activity;
    }

    public void SendNotification(User user, string message)
    {
        _activityMethod.SendNotification(user, message);
    }

    public void StartActivity(Activity activity) {
        SetActivityPriority(activity.Priority);
        activity.Notify();
    }
}
