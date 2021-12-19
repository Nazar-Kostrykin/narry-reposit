using System;
using System.IO;

namespace kostrykin4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var studList = new Container();
            studList.Add(new Student("Луговой Александр Евгениевич", new DateTime(2000, 10, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 94));
            studList.Add(new Student("Шапошник Ангелина Андреевна", new DateTime(1998, 10, 10), new DateTime(2017, 9, 1), "Б", 217, "Э", "Энергетическое машиностроение", 68));
            studList.Add(new Student("Орлова Влада Станиславовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 94));
            studList.Add(new Student("Кострыкин Назар Сергеевич", new DateTime(2002, 12, 10), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 86));
            ContFile helper = new ContFile(studList);
            var studList2 = helper.Read("F:\\unik\\3 course\\DOT.NET\\LAB\\kostrykin3\\kostrykin3\\output.txt");
            var name = "Кострыкин Назар Сергеевич";
            var stud = studList.GetStudent(name);

            Console.WriteLine($"Группа студента {name}: {stud.Group}");
            Console.WriteLine("\n");

            Console.WriteLine($"Курс студента {name}: {stud.Year}");
            Console.WriteLine("\n");

            Console.WriteLine($"Семестр студента {name}: {stud.Semester}");
            Console.WriteLine("\n");

            Console.WriteLine($"Возраст студента {name}: {stud.Age}");
            Console.WriteLine("\n");
        }
    }
}
