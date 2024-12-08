namespace TestSkill
{
  class User
    {
        public string login;
        public string email;
       public string Login {
            get
            {
                return login;
            }
            set
            {
                if(value.Length<3) 
                {
                    Console.WriteLine("A username of less than 3 characters is not allowed!");
                    login = "Default";
                }
                login = value;
            }
        }
        public string Email
        {

            get 
            {
                return email;
            }

            set 
            {
                if(value.IndexOf("@") == -1|| value.IndexOf("@") == 0) 
                {
                    Console.WriteLine("An email cannot be without @");
                    email = "Default@";
                }
               email = value;
            }
        }

        public User(string login,string email)
        {
            Login = login;
            Email = email;
        }
        public void ShowUser()
        {

        }
    }
}
