using System;

namespace kostrykin2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Container studList = new Container();
            studList.Add(new Student("Луговой Александр Евгениевич", 2, 7, 2000, 2017, "KIT-117b", 85));
            studList.Add(new Student("Шапошник Ангелина Андреевна", 4, 8, 1998, 2017, "KIT-119b", 68));
            studList.Add(new Student("Орлова Влада Станиславовна", 11, 2, 2001, 2019, "KIT-119b", 90));
            studList.Add(new Student("Кострыкин Назар Сергеевич", 10, 12, 2001, 2019, "KIT-119b", 80));
            Console.WriteLine("\nВывод в полном формате\n");
            studList.PrintAll(false);
            studList.PrintAll(true);
            Console.WriteLine("\nПолучение информации о конкретном студенте по имени Кострыкин Назар Сергеевич: \n");
            Console.WriteLine(studList.GetStudent("Кострыкин Назар Сергеевич").ToString());
            int i = 1;
            Console.WriteLine("\nВывод студентов с их успеваемостью: \n");
            foreach (Student stud in studList)
            {
                Console.WriteLine(i + "." + stud.Name + ": " + stud.Progress + "\n");
                i++;
            }
            Console.ReadLine();
        }
    }
}