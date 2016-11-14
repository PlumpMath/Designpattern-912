using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 公交车的观察者模式
{
    public class Car
    {
        /// <summary>
        /// 车上的人
        /// </summary>
         static List<Person> personList = new List<Person>();
        /// <summary>
        /// 到站的委托
        /// </summary>
        /// <param name="stationName"></param>
        public delegate void StationHander(string stationName);
        /// <summary>
        /// 汽车到站的事件
        /// </summary>
        public static event StationHander StationEvent;

        private static void OnStation()
        {
            StationEvent("到站的名称");
        }

        public static void Add(Person person)
        {
            person.StopEvent += new EventHandler(AddStopEvent);
            personList.Add(person);
        }

        static void AddStopEvent(object sender, EventArgs e)
        {

        }
         
    }
}
