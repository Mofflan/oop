
namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar 2 objekt med radie 6 och 5
            Circle circleA = new Circle(6);
            Circle circleB = new Circle(5);
           
            //Printar ut info
            Console.WriteLine($"Radie 6 av Arean är: {circleA.GetArea():F2} och omkretsen är {circleA.GetOmkrets():F2}\n ");
            Console.WriteLine($"Radie 5 av Arean är: {circleB.GetArea():F2} och omkreten är {circleB.GetOmkrets():F2}");
        }
        
    }
}
