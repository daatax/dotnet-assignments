using System;

namespace Intro.Lesson8.Interfaces
{
    public class Car : Vehicle, IVehicle
    {

        private int numberOfDoors;
        private double trunkCapacity;

        public int NumberOfDoors {
            get { return numberOfDoors; }
            set {
                if (value >= 2) {
                    numberOfDoors = value;
                    return;
                }
                throw new ArgumentException("There are no cars with less than two doors.");
            }
        }
        public double TrunkCapacity {
            get { return trunkCapacity; }
            set {
                if (value >= 0) {
                    trunkCapacity = value;
                    return;
                }
                throw new ArgumentException("Trunk's capacity cannot be negative.");
            }
        }

        public Car(string make, string model, int year, double price, int numberOfDoors, double trunkCapacity)
            : base(make, model, year, price) {
            NumberOfDoors = numberOfDoors;
            TrunkCapacity = trunkCapacity;
        }

        public void Start() {
            Console.WriteLine("The Engine starts!");
        }

        public void Stop() {
            Console.WriteLine("The Engine stoped!");
        }

        public string GetVehicleInfo() {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}, " +
                $"Doors: {NumberOfDoors}, Trunk Capacity: {TrunkCapacity} cubic feet";
        }
    }
}