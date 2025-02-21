using Extra.Enums;
using Extra.Observer;

namespace Extra.Subject;
public class Activity : ASubject
{
    public string Title { get; set; }
    public List<User> Users { get; set; } = new List<User>();
    public Priority Priority { get; set; }


    public Activity(string title,  Priority priority) { 
        Title = title;
        Priority = priority;
    }

    public void AddUser(User user) { 
        Users.Add(user);
        Attach(user);
    }
}
