Stack<int> numbers = new Stack<int>();

numbers.Push(10);
numbers.Push(20);
numbers.Push(30);

Console.WriteLine(numbers.Peek());    // 30, vẫn còn trong Stack
Console.WriteLine(numbers.Pop());     // 30, đã bị lấy ra
Console.WriteLine(numbers.Count);     // 2


// Cách 1: kiểm tra trước
if (numbers.Count > 0)
{
    int top = numbers.Pop();
    Console.WriteLine($"Lấy được {top}");
}

// Cách 2: TryPop
if (numbers.TryPop(out int value))
    Console.WriteLine($"Lấy được {value}");
else
    Console.WriteLine("Stack rỗng");



numbers.Push(1);
numbers.Push(2);
numbers.Push(3);

foreach (int n in numbers)
    Console.WriteLine(n);     // 3->2->1


static string Reverse(string input)
{
    var stack = new Stack<char>();
    foreach (char c in input)
        stack.Push(c);

    var result = new System.Text.StringBuilder();
    while (stack.Count > 0)
        result.Append(stack.Pop());
    return result.ToString();
}

Console.WriteLine(Reverse("DNTU"));
