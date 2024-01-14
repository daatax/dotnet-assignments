using System;

namespace Intro.Lesson8.Interfaces
{
    public class Vehicle
    {

        private string make;
        private string model;
        private int year;
        private double price;

        public string Make {
            get { return make; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    make = value;
                    return;
                }
                throw new ArgumentException("Vehicle's Make cannot be null or empty.");
            }
        }
        public string Model {
            get { return model; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    model = value;
                    return;
                }
                throw new ArgumentException("Vehicle's Model cannot be null or empty.");
            }
        }
        public int Year {
            get { return year; }
            set {
                if (value >= 1886) {
                    year = value;
                    return;
                }
                throw new ArgumentException("There were no cars made before 1886.");
            }
        }
        public double Price {
            get { return price; }
            set {
                if (value >= 0) {
                    price = value;
                    return;
                }
                throw new ArgumentException("Vechicle's Price cannot be less than 0.");
            }
        }

        public Vehicle(string make, string model, int year, double price) {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
    }
}