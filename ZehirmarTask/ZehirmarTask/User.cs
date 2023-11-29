namespace ZehirmarTask
{
    internal class User
    {
        private string password;

        public int Id { get; set; }
        public string  Fullname { get; set; }
        public string Email { get; set; }
        
        public string Password { get=> password; set
            {
                if (PasswordChecker(value))
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("ay xanim yer get");
                }

            } 
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsNumber))
            {
                return false;
            }
            return true;
        }


        public void ShowInfo(int Id, string Fullname, string Email)
        {
            Console.WriteLine($"{Id} {Fullname} {Email}" );
        }

    }
}
