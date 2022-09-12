Console.WriteLine("Ввведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "тата")
{
    Console.WriteLine("Ура, это же  моя любимая Тата!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}