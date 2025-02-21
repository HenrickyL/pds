using Extra.Observer;

namespace Extra.Strategy;

public class MailNotification : IActivityMethod
{
    public void SendNotification(User user, string message)
    {
        Console.WriteLine($"> Send E-Mail: {message} - To: {user.Name}.");
    }
}
