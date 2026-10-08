namespace Lab18_Queue
{
    public class StudentQueue
    {
        private Queue<Student> queue;

        public StudentQueue()
        {
            queue = new Queue<Student>();
        }


        public void Add(Student student)
        {
            queue.Enqueue(student);
        }

        public Student Remove()
        {
            if (queue.Count == 0)
            {
                return null;
            }

            return queue.Dequeue();
        }

        public Student Peek()
        {
            if (queue.Count == 0)
            {
                return null;
            }

            return queue.Peek();
        }

        public int Count()
        {
            return queue.Count;
        }

        public void ShowAll()
        {
            foreach (Student student in queue)
            {
                student.Show();
            }
        }
    }
}
