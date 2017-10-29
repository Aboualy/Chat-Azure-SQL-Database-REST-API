
namespace Backend.Models
{
    public class User
    {


        public int id;
        public string username;
        public string firstname;
        public string lastname;

        public User() { }
        public User(string username) { this.username = username;}
		
        public User(int id, string username, string firstname, string lastname)
        {
            this.id = id;
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
        }






        











    }
}
