namespace Identity;
public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; } = Role.RegularUser;
}
public enum Role
{
    Admin, RegularUser, PrivilegedUser, Moderator
}

public class UserStore
{
    private List<User> userstore;
    public UserStore()
    {
        userstore = new List<User>();
        
    }

    void Register(RegisterBody r)
    {
        userstore.Add(new User()
        {
            Login = r.Login, Password = r.Password, Role = Role.RegularUser,
        });
    }

    public string Authorization(AuthorizationBody a)
    {
        if (userstore.Find(user=>user.Login==a.Login).Password==a.Password)
        {
            return("вы вошли");
        }
        else
        {
            return("вход не осуществился");
        }
    }
}

public class RegisterBody
{
    public string Login { get; set; }
    public string Password { get; set; }
}

public class AuthorizationBody
{
    public string Login { get; set; }
    public string Password { get; set; }
}