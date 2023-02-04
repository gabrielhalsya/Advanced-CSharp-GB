namespace linQ
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            IEnumerable<int> numQuery1 = from num in numbers where num%2 == 0 select num;
            IEnumerable<int> numQuery2 =numbers.Where(num => num%2 == 0);

            foreach(int i in numQuery1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(System.Environment.NewLine);
            foreach (int i in numQuery2)
            {
                Console.WriteLine(i);
            }

            List<Car> ListOfCars = new List<Car>()
            {
                new Car(name:"Toyota",owner:"Gabi,",model:2015),
                new Car(name:"Mitsubishi",owner:"Gabi2,",model:2021),
                new Car(name:"Hyundai",owner:"Gabi3,",model:2018),
                new Car(name:"Daihatsu",owner:"Gabi4,",model:2000),
            };

            IEnumerable<Car> QueryResult = from car in ListOfCars
                                           select car;

            foreach(Car car in QueryResult)
            {
                Console.WriteLine(car.Name);
            }

        }

    }

    class Car
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public short Model { get; set; }

        public Car(string name, string owner, short model)
        {
            Name = name;
            Owner = owner;
            Model = model;
        }

        public override string? ToString()
        {
            return $"Name : {Name} | Owner : {Owner} | Model : {Model}";
        }
    }
}