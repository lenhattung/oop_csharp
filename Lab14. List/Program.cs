using Lab14._List;

class Program
{
    static void Main(string[] args)
    {
        StudentMS studentMS = new StudentMS();

        while (true)
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Show All Students");
            Console.WriteLine("5. Find Student By Name");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    studentMS.Add();
                    break;

                case 2:
                    studentMS.Delete();
                    break;

                case 3:
                    //studentMS.Update();
                    break;

                case 4:
                    studentMS.ShowAll();
                    break;

                case 5:
                    studentMS.FindByName();
                    break;

                case 0:
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
