namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack Stack = new Stack(5);
            Stack.Push(10);
            Stack.Push(20);
            Stack.Push(30);
            Stack.Push(40);
            Stack.Push(50);
            Stack.Push(60);
            Console.WriteLine(Stack.Pop());
            Console.WriteLine(Stack.peek());
            Console.WriteLine(Stack.Pop());
            Stack.Push(60);
            Console.WriteLine(Stack.peek());
        }
    }
}