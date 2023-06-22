// Приветствие пользователя.
Console.Clear();
Console.Write("Введите имя ");
string username = Console.ReadLine();
if (username.ToLower() == "наташа")
{
    Console.Write("Не может быть - это же сама Натали");
    Console.Write("!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write("!");
}