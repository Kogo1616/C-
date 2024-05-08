Console.WriteLine("Hello, World!");


List<int> numbers = new();
numbers.Add(3);

var filter = numbers
    .Where(x => x > 1);