namespace Q4;
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
        Usuario user1 = new Usuario("Henricky");
        Usuario user2 = new Usuario("Luis");
        Usuario user3 = new Usuario("Ryan");
        Usuario user4 = new Usuario("Almir");


        DataBase.Instance.AddUser(user1);
        DataBase.Instance.AddUser(user2);
        DataBase.Instance.AddUser(user3);
        DataBase.Instance.AddUser(user4);

        DataBase.Instance.GetUsers().ForEach(u => Console.WriteLine(u));

    }
}