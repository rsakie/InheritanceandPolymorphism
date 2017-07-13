using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolymorphism
{
    class Automobile : Vehicle
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels {get; }
        public float WheelSize {get; }
        public int NumberOFDoors {get; }


        public Automobile()
        {

        }

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats,
            int carryingCapacity, string color,double movementSpeed)
        {
            this.numberOfDoors = numberOfDoors;
            this.wheelSize = wheelSize;
            this.numberOfWheels = numberOfWheels;
            this.seats = seats;
            this.color = color;
            this.carryingCapacity = carryingCapacity;
            this.movementSpeed = movementSpeed;

        }

    }
}
