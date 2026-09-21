
namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new Circle(6);
            Circle circleB = new Circle(5);
           

            Console.WriteLine($"Radie 6 av Arean är: {circleA.GetArea()} och omkretsen är {circleA.GetOmkrets()}\n ");
            Console.WriteLine($"Radie 5 av Arean är: {circleB.GetArea()} och omkreten är {circleB.GetOmkrets()}");
        }
        
    }
}
