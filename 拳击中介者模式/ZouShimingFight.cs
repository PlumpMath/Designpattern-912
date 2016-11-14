using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击中介者模式
{
    /// <summary>
    /// 具体实现
    /// </summary>
    public class ZouShimingFight : AbstractFight
    {
        public override double ChangeGrade(double num, AbstractMediator fight)
        {
           return  fight.ZouEmbattled(num);
        }
    }
}
