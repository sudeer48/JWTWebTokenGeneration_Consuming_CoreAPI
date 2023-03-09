namespace JWTWebToken.Models
{
    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserConstants
    {
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ Username="sudeer",Password="sudeer123",Role="Admin1"}
            };
    }
}
