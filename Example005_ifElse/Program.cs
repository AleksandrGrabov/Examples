internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Введите имя пользователя: ");
    string username = Console.ReadLine();

    if (username.ToLower() == "маша")
    {
      Console.Write("Ура, это же МАША");
    }
    else
    {
      System.Console.Write("Привет, ");
      System.Console.WriteLine(username);
    }
  }
}