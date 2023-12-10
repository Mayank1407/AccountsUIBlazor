// See https://aka.ms/new-console-template for more information

    public class Car
    {
        public void turnonCar()
        {
            Console.WriteLine("turn on the manual car");
        }
        public void turnonOff()
        {
            Console.WriteLine("turn off the manual car");
        }
        private void change_piston_speed()
        {
            Console.WriteLine("change piston speed implementation");
        }
        private void Move_break_pads()
        {
            Console.WriteLine("Move_break_pads implementation");
        }
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.turnonCar();
            obj.turnonOff();

        }
    }

