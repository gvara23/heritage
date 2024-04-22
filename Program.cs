namespace heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal human = new Human();
            Animal monkey = new Monkey();
            Animal elephant = new Elephant();
            Animal turtle = new Turtle();

            Console.WriteLine("Human:");
            human.Move();
            human.Eat();
            Console.WriteLine();

            Console.WriteLine("Monkey:");
            monkey.Move();
            monkey.Eat();
            Console.WriteLine();

            Console.WriteLine("Elephant:");
            elephant.Move();
            elephant.Eat();
            Console.WriteLine();

            Console.WriteLine("Turtle:");
            turtle.Move();
            turtle.Eat();
        }
    }


    public abstract class Animal
    {
        protected int _legsCount;

        public Animal(int legsCount)
        {
            _legsCount = legsCount;
        }

        public abstract void Move();

        public void Eat()
        {
            Console.WriteLine("I'm eating.");
        }
    }

    public class Bipedal : Animal
    {
        public Bipedal(int legsCount) : base(legsCount)
        {
        }

        public override void Move()
        {
            Console.WriteLine("I'm walking on two legs.");
        }
    }

    public class Quadrupedal : Animal
    {
        public Quadrupedal(int legsCount) : base(legsCount)
        {
        }

        public override void Move()
        {
            Console.WriteLine("I'm walking on four legs.");
        }
    }

    public class Human : Bipedal
    {
        public Human() : base(2)
        {

        }
    }

    public class Monkey : Bipedal
    {
        public Monkey() : base(2)
        {

        }
    }

    public class Elephant : Quadrupedal
    {
        public Elephant() : base(4)
        {

        }
    }

    public class Turtle : Quadrupedal
    {
        public Turtle() : base(4)
        {

        }
    }

  
}
