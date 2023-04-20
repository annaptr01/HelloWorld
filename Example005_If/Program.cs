Console.Write("Insert user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Yay! Welcome Maria!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}