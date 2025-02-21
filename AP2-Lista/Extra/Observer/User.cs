using Extra.Singleton;
using Extra.Subject;
namespace Extra.Observer;
public class User : IObserver
{
    public string Name { get; set; }
    public User(string name) { 
        Name = name;
    }

    public void Update(ISubject subject)
    {
        if (subject is Activity) { 
            Activity activity = (Activity)subject;
            ActivityManager.Instance.SendNotification(this, activity.Title);
        }
    }
}
