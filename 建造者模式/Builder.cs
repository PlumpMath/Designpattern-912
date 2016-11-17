using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract  class Builder
    {
        //安装CPU
        public abstract void BuildPartCPU();
        //安装主板
        public abstract void BuilePartMainBoard();

        //获得组装好的电脑
        public abstract Computer GetComputer();
    }
}
