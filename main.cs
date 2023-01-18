using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {

      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "`~!@#$%^&*()-_=+";

      Console.WriteLine("Please enter a password:");
      string password = Console.ReadLine();

      int score = 0;

      if (password.Length >= minLength) {
        score++;
      }

      if (Tools.Contains(password, uppercase)) {
        score++;
      }

      if (Tools.Contains(password, lowercase)) {
        score++;
      }

      if (Tools.Contains(password, digits)) {
        score++;
      }

      if (Tools.Contains(password, specialChars)) {
        score++;
      }
      
      switch (score) {
        case 5:
          Console.WriteLine("This is an excellent password");
          break;  
        case 4:
          Console.WriteLine("This is a very strong password");
          break;
        case 3:
          Console.WriteLine("This is a strong password");
          break;
        case 2:
          Console.WriteLine("This is a decent password");
          break;
        case 1:
          Console.WriteLine("This is going to get hacked honestly");
          break;     
        default:
          Console.WriteLine("Please enter a better password");
          break;   
      }

    }
  }
}
