using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
[Serializable]
public class Person
{
    public string Name { get; set; }
    public List<int> Marks { get; set; }
    public double AverageMark => Marks.Average();
}
public class Program
{
    static void Main(string[] args)
    {
        List<Person> people = DeserializePeople("C:\\Users\\Student28\\Desktop\\people.xml");
        Console.WriteLine("Команды:");
        Console.WriteLine("0 - выход");
        Console.WriteLine("1 - Показать самого худшего ученика");
        Console.WriteLine("2 - Показать самого лучшего ученика");
        Console.WriteLine("3 - Показать весь список");
        Console.WriteLine("4 - Показать учеников со средним баллом больше ...");
        Console.Write("Введите команду");
        switch (Console.ReadLine())
        {
            case "0":
                break;
            case "1":
                ShowBestStudent(people);
                break;
            case "2":
                ShowWorstStudent(people);
                break;
            case "3":
                ShowAllStudents(people);
                break;
            case "4":
                Console.WriteLine("Введите средний балл: ");
                if (double.TryParse(Console.ReadLine(), out double averageThreshold))
                {
                    ShowStudentsAboveAverage(people, averageThreshold);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
                break;




        }
        Console.ReadKey();
    }
    static List<Person> DeserializePeople(string fileName)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
        using (FileStream stream = new FileStream(fileName, FileMode.Open))
        {
            return (List<Person>)serializer.Deserialize(stream);
        }
    }
    static void ShowBestStudent(List<Person> people)
    {
        Person bestStudent = people.OrderByDescending(p => p.AverageMark).First();
        Console.WriteLine($"Самый лучший ученик: {bestStudent.Name} , средний балл: {bestStudent.Marks}");
    }
    static void ShowWorstStudent(List<Person> people)
    {
        Person worstStudent = people.OrderBy(p => p.AverageMark).First();
        Console.WriteLine($"Самый худший ученик: {worstStudent.Name}, средний балл: {worstStudent.AverageMark}");
    }
    static void ShowAllStudents(List<Person> people)
    {
        foreach (Person person in people)
        {
            Console.WriteLine($"Имя: {person.Name}, Средний балл: {person.AverageMark}");
        }
    }
    static void ShowStudentsAboveAverage(List<Person> people, double averageThreshold)
    {
        foreach (Person person in people.Where(p => p.AverageMark > averageThreshold))
        {
            Console.WriteLine($"Имя: {person.Name}, Средний балл: {person.AverageMark}");
        }
    }
}
