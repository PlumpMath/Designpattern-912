using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 公交车的观察者模式
{
    public class Person
    {
        public event EventHandler StopEvent;
        public Person()
        {
            Car.StationEvent+= new Car.StationHander(StationEvent);
        }
        public void StationEvent(string stationName)
        {
            if (stationName == "1")
            {
                StopEvent(null, null);
            }
        }
    }
}
