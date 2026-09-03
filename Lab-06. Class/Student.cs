namespace Lab_06._Class
{
    public class Student
    {
        private string _studentID;
        private string _fullName;
        private int _age;
        private double _gpa;
        private MyDate _dateOfBirth;

        // === Constructor ===
        public Student()
        {
            _studentID = "";
            _fullName = "";
            _age = 0;
            _gpa = 0.0;
            _dateOfBirth = new MyDate();
        }

        // Constructor có tham số theo UML: StudentID, FullName, Age, GPA
        public Student(string StudentID, string FullName, int Age, double GPA)
        {
            _studentID = StudentID;
            _fullName = FullName;
            _age = Age;
            _gpa = GPA;
            _dateOfBirth = new MyDate(); // Tạo ngày sinh mặc định
        }

        // === Phương thức theo UML ===
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {_studentID}");
            Console.WriteLine($"Fullname: {_fullName}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"GPA: {_gpa:F2}");
            Console.WriteLine($"Date of birth: {_dateOfBirth.GetDay()}/{_dateOfBirth.GetMonth()}/{_dateOfBirth.GetYear()}");
            Console.WriteLine("---------------------------");
        }

        // Getter và Setter
        public string GetStudentID()
        {
            return _studentID;
        }

        public void SetStudentID(string StudentID)
        {
            _studentID = StudentID;
        }

        public string GetFullName() => _fullName;

        public void SetFullName(string value) => _fullName = value;

        public int GetAge() => _age;
        public void SetAge(int value) => _age = value;

        public double GetGpa() => _gpa;
        public void SetGpa(double value) => _gpa = value;

        public MyDate GetDateOfBirth() => _dateOfBirth;
        public void SetDateOfBirth(MyDate value) => _dateOfBirth = value;

    }

}