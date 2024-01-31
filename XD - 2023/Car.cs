using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD___2023 {
    public class Car : Vehicle {

        //Fields
        private int carSeats;
        //private string color;
        //private string name;
        //private int maxSpeed; //field 
        //private int year;

        //Properties
        public int CarSeats { get; set; }
        //public string  Name { //property
        //    get { return name; }
        //    set { name = value; } 
        //}
        //public string Color {
        //    get { return color; }
        //    set { color = value; }
        //}

        //public int Year {
        //    get { return year; }
        //    //set { year = value; }
        //    set { 
        //    if (value < 1980) {
        //            throw new Exception("Please pass a correct value");
        //        }
        //    else {
        //            year = value;
        //        }
        //    }
        //}

        //Constructors
        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue,int carSeatsNo) : base(nameName, colorName, yearValue, maxSpeedValue){ 
            carSeats = carSeatsNo;
        }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue, string eng_type, int carSeatsNo) : base(nameName, colorName, yearValue, maxSpeedValue, eng_type) {
            carSeats = carSeatsNo;
        }
        public Car(string nameName, int carSeatsNo) : base (nameName){
            carSeats = carSeatsNo;
        }
        public void fullThrottle() {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }

    }
}
