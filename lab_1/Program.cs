using System;
namespace kostrykin01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Шапошник Ангелина Андреевна", new DateTime(2005, 04, 24 ), new DateTime(2017, 9, 1), "Б", 122, "КИТ", "Компьютерная инжерения", 87);
            Student stud2 = new Student("Кострыкин Назар Сергеевич", new DateTime(2001, 11, 12), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерная инженерия", 92);

            Console.WriteLine(stud1.ToText());
            Console.WriteLine("\n");
            Console.WriteLine(stud2.ToText());
        }
    }
}
