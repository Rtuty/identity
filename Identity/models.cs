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