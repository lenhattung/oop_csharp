using Lab18_Queue;

Queue<int> numbers = new Queue<int>(); // FIFO = First in First out

numbers.Enqueue(100);
numbers.Enqueue(200);
numbers.Enqueue(300);

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(numbers.Peek());

//Console.WriteLine(numbers.Contains(300));

//while (numbers.Count > 0)
//{
//    Console.WriteLine(numbers.Dequeue());
//}

//Queue<Student> queue = new Queue<Student>();

//queue.Enqueue(new Student("SV01", "An"));
//queue.Enqueue(new Student("SV02", "Binh"));
//queue.Enqueue(new Student("SV03", "Cuong"));

//foreach (Student student in queue)
//{
//    student.Show();
//}

//if (queue.Count > 0)
//{
//    Student st = queue.Dequeue();
//    st.Show();
//}
//else
//{
//    Console.WriteLine("Queue is empty!");
//}

StudentQueue queue = new StudentQueue();

queue.Add(new Student("SV01", "An"));
queue.Add(new Student("SV02", "Binh"));
queue.Add(new Student("SV03", "Cuong"));

Console.WriteLine("Danh sach sinh vien:");

queue.ShowAll();

Console.WriteLine("\nSo luong: " + queue.Count());

Console.WriteLine("\nSinh vien tiep theo:");

Student student = queue.Peek();

if (student != null)
{
    student.Show();
}

Console.WriteLine("\nPhuc vu sinh vien:");

student = queue.Remove();

if (student != null)
{
    student.Show();
}

Console.WriteLine("\nQueue sau khi phuc vu:");

queue.ShowAll();