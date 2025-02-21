namespace Q4;
public class DataBase
{
    private static DataBase _instance;
    public static DataBase Instance { 
        get { 
            if(_instance == null)
            {
                _instance = new DataBase();
            }
            return _instance;
        } 
    }

    private List<Usuario> _users;
    private DataBase() {
        _users = new List<Usuario>();
    }


    public void AddUser(Usuario user) {
        _users.Add(user);
    }
    public void RemoveUser(int id)
    {
        Usuario user = _users.First(x=>x.Id == id);
        if (user != null) {
            _users.Remove(user);
        }else throw new Exception("User NotFound");
    }
    public void Update(int id, Usuario userData)
    {
        Usuario user = _users.First(x => x.Id == id);
        if (user != null)
        {
            _users.Add(user);
        }
    }

    public List<Usuario> GetUsers() { 
        return _users;
    }

    public Usuario GetById(int id)
    {
        return _users.First(x => x.Id == id);
    }
}
