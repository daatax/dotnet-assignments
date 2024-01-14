using System;

namespace Intro.Lesson8.Interfaces
{
    public class Motorcycle : Vehicle, IVehicle
    {
        private double engineSize;

        public double EngineSize {
            get { return engineSize; }
            set {
                if (value > 0) {
                    engineSize = value;
                    return;
                }
                throw new ArgumentException("Engine size cannot be less than or equal to 0.");
            }
        }

        public Motorcycle(string make, string model, int year, double price, double engineSize)
            : base(make, model, year, price) {
            EngineSize = engineSize;
        }

        public void Start() {
            Console.WriteLine("Motorcycle is starting...");
        }

        public void Stop() {
            Console.WriteLine("Motorcycle is stopping...");
        }
        public string GetVehicleInfo() {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, " +
                $"Price: {Price}, Engine Size: {EngineSize}cc";
        }

    }
}