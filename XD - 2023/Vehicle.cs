using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD___2023 {
    public  class Vehicle {
        public string engine_type = "gas";  // Vehicle field

        //Fields
        protected string color;
        protected string name;
        protected int maxSpeed; //field 
        protected int year;

        //Properties
        public string Name { //property
            get { return name; }
            set { name = value; }
        }
        public string Color {
            get { return color; }
            set { color = value; }
        }

        public int Year {
            get { return year; }
            //set { year = value; }
            set {
                if (value < 1980) {
                    throw new Exception("Please pass a correct value");
                } else {
                    year = value;
                }
            }
        }


        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
