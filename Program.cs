// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
static float change_to_give(float change){
    Console.WriteLine(change);
    return (change);
}

Console.WriteLine("Enter change: ");
float change = Single.Parse(Console.ReadLine());
// Console.WriteLine(change);

change_to_give(change);