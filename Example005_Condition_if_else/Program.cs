Console.Write("Введите имя пользователя: ");
var username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!");
}
