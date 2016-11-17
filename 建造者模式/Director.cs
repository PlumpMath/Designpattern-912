using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    public class Director
    {
        /// <summary>
        /// 指挥者
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuilePartMainBoard();
        }
    }
}
