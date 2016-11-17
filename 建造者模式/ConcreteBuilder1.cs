using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 具体的组装电脑的人
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU");
        }

        public override void BuilePartMainBoard()
        {
            computer.Add("Main board");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
