namespace Lab14._List
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        // Nhập thông tin Student
        public void Input()
        {
            Console.Write("Enter ID: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter GPA: ");
            GPA = double.Parse(Console.ReadLine());
        }

        // Hiển thị thông tin Student
        public void Show()
        {
            Console.WriteLine(
                $"ID: {Id}, Name: {Name}, GPA: {GPA}"
            );
        }
    }

}
