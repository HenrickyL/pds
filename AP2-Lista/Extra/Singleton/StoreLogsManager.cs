using Extra.Entities;
using Extra.Observer;

namespace Extra.Singleton;
public class StoreLogsManager
{
    private static int _idGenerator = 0;

    private static StoreLogsManager _instance;
    public static StoreLogsManager Instance {
        get { 
            if(_instance == null) _instance = new StoreLogsManager(); 
            return _instance;
        }
    }

    private List<Log> _logs = new();

    private StoreLogsManager() { }

    public void AddLog(User user, string message) { 
        _logs.Add(new Log { 
            Id = ++_idGenerator, 
            User = user, 
            Message = message,
            CreateAt = DateTime.Now
        });
    }

    public void PrintReports() {
        Console.WriteLine("-------------Report---------------");
        _logs.ForEach(log => { 
            Console.WriteLine(log); 
        });
    }
}
