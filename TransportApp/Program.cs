using System;

namespace TransportApp
{
    public abstract class Transport
        {
            public int Year { get; set; }
            public int Weight { get; set; }
            public string Color { get; set; }


            protected Transport() 
            {
                Year = 0;
                Weight = 0;
                Color = "Неизвестно";
            }

            protected Transport(int year, int weight, string color)
            {
                Year = year;
                Weight = weight;
                Color = color;
            }

            public abstract void Info();
        }
    class Train : Transport
    {
        public int Сarriages { get; set; }
        public Train(int year, int weight, string color, int carriages) : base(year, weight, color)
        {
            Сarriages = carriages;
        }

        public override void Info()
        {
            Console.WriteLine("Поезд");
            Console.WriteLine($"Год выпуска: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Цвет: {Color}");
            Console.WriteLine($"Вагоны: {Сarriages}\n");
        }
    }
    public class Airplane : Transport
    {
        public double WingLength { get; set; }
        public Airplane(int year, int weight, string color, double wingLength) : base(year, weight, color)
        {
            WingLength = wingLength;
        }

        public override void Info()
        {
            Console.WriteLine("Самолет");
            Console.WriteLine($"Год выпуска: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Цвет: {Color}");
            Console.WriteLine($"Длина крыла: {WingLength:0.00}\n");
        }
    }
     public class Car : Transport
    {
        public double Speed { get; set; }
        public Car(int year, int weight, string color, double speed) : base(year, weight, color)
        {
            Speed = speed;
        }

        public override void Info()
        {
            Console.WriteLine("Авто");
            Console.WriteLine($"Год выпуска: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Цвет: {Color}");
            Console.WriteLine($"Скорость: {Speed:0.00}\n");
        }
    }
    public class Truck : Car
    {
        public double BodyLength { get; set; }
        public Truck(int year, int weight, string color, double speed, double bodyLength) : base(year, weight, color, speed)
        {
            BodyLength = bodyLength;
        }

        public override void Info()
        {
            Console.WriteLine("Легковое авто");
            Console.WriteLine($"Год выпуска: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Цвет: {Color}\n" +
                              $"Скорость: {Speed:0.00}");
            Console.WriteLine($"Длина корпуса: {BodyLength:0.00}\n");
        }
    }
    public class Passenger : Car
    {
        public string PassengerType { get; set; }
        public Passenger(int year, int weight, string color, double speed, string passengerType) : base(year, weight, color, speed)
        {
            PassengerType = passengerType;
        }

        public override void Info()
        {
            Console.WriteLine("Грузовое авто");
            Console.WriteLine($"Год выпуска: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Цвет: {Color}\n" +
                              $"Скорость: {Speed:0.00}");
            Console.WriteLine($"Тип кузова: {PassengerType}\n");
        }
    }
    public class PassengerPlane : Airplane
    {
        public int Seats { get; set; }
        public PassengerPlane(int year, int weight, string color, double wingLength, int seats) : base(year, weight, color, wingLength)
        {
            Seats = seats;
        }

        public override void Info()
        {
            Console.WriteLine("Пассажирский самолет");
            Console.WriteLine($"Год выпуска: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Цвет: {Color}\n" +
                              $"Длина крыла: {WingLength:0.00}");
            Console.WriteLine($"Места: {Seats}\n");
        }
    }
    public class CargoPlane : Airplane
    {
        public double Capacity { get; set; }
        public CargoPlane(int year, int weight, string color, double wingLength, double capacity) : base(year, weight, color, wingLength)
        {
            Capacity = capacity;
        }
        public override void Info()
        {
            Console.WriteLine("Грузовой самолет");
            Console.WriteLine($"Год выпуска: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Цвет: {Color}\n" +
                              $"Длина крыла: {WingLength:0.00}");
            Console.WriteLine($"Вместимость: {Capacity:0.00}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transport[] n = new Transport[5];
            n[0] = new Passenger(1990,2000,"Синий",140.5,"Пикап");
            n[1] = new Train(192,200000,"Черный",60);
            n[2] = new Truck(1995,1500,"Красный",250.5,2.50);
            n[3] = new CargoPlane(1998,40000,"Зеленый",15.9,20000.60);
            n[4] = new PassengerPlane(20000,20000,"Желтый",11.8,120);
            foreach (var transport in n)
            {
                transport.Info();
            }
        }
    }
}