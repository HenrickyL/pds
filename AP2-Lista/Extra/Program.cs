using Extra.Enums;
using Extra.Observer;
using Extra.Singleton;
using Extra.Subject;

namespace Extra;
public class Program {
    public static void Main(string[] args) {
        try
        {
            Start();
        }
        catch (Exception ex) { 
            Console.WriteLine(ex.ToString());
        }
    }

    public static void Start() { 
        User user1 = new User("Henricky");
        User user2 = new User("Luis");
        User user3 = new User("Danilo");
        User user4 = new User("Ryan");
        User user5 = new User("Almir");
        User user6 = new User("Andreina");
        User user7 = new User("Tiago");

        Activity activityHigh = ActivityManager.Instance.CreateActivity("Atender Chamado",Priority.High);
        Activity activityMedium = ActivityManager.Instance.CreateActivity("Entregar Relatorio", Priority.Medium);
        Activity activityLow = ActivityManager.Instance.CreateActivity("Atualização de estoque", Priority.Low);

        activityHigh.AddUser(user1);
        activityHigh.AddUser(user3);
        activityHigh.AddUser(user4);
        activityHigh.AddUser(user7);

        activityMedium.AddUser(user2);
        activityMedium.AddUser(user1);
        activityMedium.AddUser(user6);


        activityLow.AddUser(user1);
        activityLow.AddUser(user2);
        activityLow.AddUser(user3);
        activityLow.AddUser(user7);
        activityLow.AddUser(user5);
        activityLow.AddUser(user4);



        ActivityManager.Instance.StartActivity(activityHigh);
        Console.WriteLine("Chegou o fim da Semana");
        ActivityManager.Instance.StartActivity(activityMedium);
        ActivityManager.Instance.StartActivity(activityLow);

        Console.WriteLine("Pediram o Relatório");
        StoreLogsManager.Instance.PrintReports();
    }
}