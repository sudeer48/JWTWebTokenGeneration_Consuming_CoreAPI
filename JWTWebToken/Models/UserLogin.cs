﻿namespace JWTWebToken.Models
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
                    new UserModel(){ Username="naeem",Password="naeem_admin",Role="Admin1"}
            };
    }
}
