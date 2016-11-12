using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class SampleSingleton3<T> where T:new()
    {
        SampleSingleton3()
        {

        }
        public static T Instance
        {
            get
            {
                return SingleCreator.instance;
            }
        }

        class SingleCreator
        {
            static SingleCreator() { }
            internal static readonly T instance = new T();

        }

    }
}
