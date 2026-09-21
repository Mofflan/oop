
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


    internal class Circle
    {
        int _radius;
        private int _test;

        public int test
        {
            get { return _test; }
            set
            {
                _test = value;
            }
        }


        public Circle(int radie)
        {
            _radius = radie;
        }
        
        public double GetArea()
        {
            double area;
            return area = _radius * _radius * Math.PI;

        }
        public double GetOmkrets()
        {
            double omkrets;
            return omkrets = _radius * 2 * Math.PI;
        }

    }
}
