namespace StructuralPatterns.Proxy
{
    public class Employee2
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Employee2(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
