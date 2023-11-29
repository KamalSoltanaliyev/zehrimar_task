using ZehirmarTask;

User user = new User();
user.Id  = 1;
user.Fullname = "Kamal Soltanaliyev";
user.Email = "kamalsoltanaliyev@gmail.com";
user.Password = "password@A12";

user.ShowInfo(user.Id, user.Fullname, user.Email);
Console.WriteLine(user.Password);