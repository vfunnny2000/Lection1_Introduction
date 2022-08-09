Console.WriteLine("Ввести имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "olga")
{
    Console.WriteLine("Hello darling!");
}
else
{
    Console.WriteLine("Hi");
    Console.WriteLine(username);
}