Console.WriteLine("Введите имя пользователя: ");
string ? username = Console.ReadLine();
if(username.ToLower() == "john")
{
    Console.WriteLine("Urah, this is John!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}