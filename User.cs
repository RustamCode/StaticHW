using System;
namespace StaticHomework
{
    internal  class User : IAccount
    {
       
        public string FullName { get; set; }

        public string Email { get; set; }

        private string _password;

        private static int _id;

        public int id { get; }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChacker(value) == false)
                {
                    Console.WriteLine($"Password should be as follows\n"+
                        $"- The password must be at least 8 characters\n"+
                        $"- The password must contain at least 1 uppercase letter\n"+
                        $"- The password must contain at least 1 lowercase letter\n"+
                        $"- The password must be at least 1 number\n");
                }
                _password = value;
                Console.WriteLine("Password bes set");
                Console.WriteLine();
                ShowInfo();
                return;

            }
        }
                    

        

        public  User(string email,string password)
        {
            Email = email;
            Password = password;
        }

        public User()
        {
            _id++;
            id = _id;
        }

    public bool PasswordChacker(string pas)
        {
            bool result = false;
            bool r1 = false;
            bool r2 = false;
            bool r3 = false;


            if (pas.Length >=8)
            {
                for (int i = 0; i < pas.Length; i++)
                {
                    if (char.IsLower(pas[i])==true)
                    {
                        r1 = true;
                    }
                    if (char.IsUpper(pas[i])==true)
                    {
                        r2 = true;
                    }
                    if (char.IsNumber(pas[i])==true)
                    {
                        r3 = true;
                    }
                        
                }
                result = r1 && r2 && r3;
            }
            return result;
           
        }

    public void ShowInfo()
        {
            if(Password!=null)
            Console.WriteLine($"User Id={id}\n" +
                $"FullName = {FullName}\n"+
                $"Email = {Email}\n");
        }
    }

    interface IAccount
    {
        bool PasswordChacker(string password);
        void ShowInfo();
        
    }
   
        
       
}
