using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldPractise
{
    internal class Agency
    {
        public Car[] Cars;
        public IEnumerator GetEnumerator()
        {
            foreach (Car car in Cars)
                yield return car;
        }
        public IEnumerable GetCars(string maker)
        {
            foreach(Car car in Cars)
                if (car.Maker == maker) yield return car;
        }
        public IEnumerable GetCars(int model)
        {
            foreach (Car car in Cars)
                if (car.ModelYear == model) yield return car;
        }
    }
}
