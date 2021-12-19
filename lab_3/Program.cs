using System;
using System.IO;

namespace khlebnikova3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var studList = new Container();
            studList.Add(new Student("Луговой Александр Евгениевич", new DateTime(2000, 10, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 94));
            studList.Add(new Student("Шапошник Ангелина Андреевна", new DateTime(2005, 11, 12), new DateTime(2017, 9, 1), "Б", 217, "Э", "Энергетическое машиностроение", 68));
            studList.Add(new Student("Орлова Влада Станиславовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 94));
            studList.Add(new Student("Хлебникова Анастасия Дмитриевна", new DateTime(2002, 12, 10), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 86));
            ContFile helper = new ContFile(studList);
            helper.Write(null, "F:\\univer\\3 course\\DOT.NET\\LAB\\lab3\\kostrykin3\\output.txt");
            var studList2 = helper.Read("F:\\univer\\3 course\\DOT.NET\\LAB\\lab3\\kostrykin3\\output.txt");
            var name = "Кострыкин Назар Сергеевич";
            var stud = studList2.GetStudent(name);
            stud.Performance += 5;
            studList2.ChangeStudent(name, stud);
        }
    }
}
