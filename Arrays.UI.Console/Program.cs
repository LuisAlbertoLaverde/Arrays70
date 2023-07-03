using Arrays.Logic;

Console.WriteLine("Hello, Arrays!");
MyArray array = new(10);

array.Fill(1, 100);
Console.WriteLine("Unsorted array =>");
Console.WriteLine(array);

array.Sort();
Console.WriteLine("Sorted array =>");
Console.WriteLine(array);
