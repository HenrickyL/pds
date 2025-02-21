using Extra.Observer;

namespace Extra.Strategy;
public class SmsNotification : IActivityMethod
{
    public void SendNotification(User user, string message)
    {
        Console.WriteLine($"> Send SMS: {message} - To: {user.Name}.");
    }
}
