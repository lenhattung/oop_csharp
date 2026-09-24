namespace Lab14._List
{
    public class StudentMS
    {
        private List<Student> students = new List<Student>();

        // Them student
        public void Add()
        {
            Student st = new Student();
            st.Input();
            students.Add(st);
            Console.WriteLine("Student added successfully!");
        }

        // Xóa student
        public void Delete()
        {
            Console.Write("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students.RemoveAt(i);
                    Console.WriteLine("Student deleted successfully!");
                    return;
                }
            }
            Console.WriteLine("Student not found!");
        }

        public void ShowAll()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Student list is empty!");
                return;
            }

            Console.WriteLine("\n===== STUDENT LIST =====");

            for (int i = 0; i < students.Count; i++)
            {
                students[i].Show();
            }
        }

        public void FindByName()
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                {
                    students[i].Show();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Student not found!");
            }
        }

    }
}
