using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display()
    {
      if (Hidden == false)
      {
        Console.WriteLine(Password);
      } 
      else
      {
        int passwordLength = Password.Length;
        string hiddenPassword = "*";
        do
        {
          hiddenPassword += "*";
        }
        while (passwordLength >= 0);
        
        Console.WriteLine(hiddenPassword);
      }
    }

    public void Reset()
    {
      Password = "";
      Hidden = false;
    }
  }
}
