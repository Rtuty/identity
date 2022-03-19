public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}
public enum Role
{
    Admin, RegularUser, PrivilegedUser, Moderator
}