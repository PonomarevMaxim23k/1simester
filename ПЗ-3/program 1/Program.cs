// 01_01.cs - Первая программа
using static System.Console;
class HelloUser
{
    static void Main()
    {
        string name;
        WriteLine("Введите Ваше имя:");
        name = ReadLine();
        WriteLine("Приветствую Вас, " + name + "!");
        WriteLine("для завершения сеанса нажмите ENTER.");
        ReadLine();
    }
}