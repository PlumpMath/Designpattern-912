using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击非中介者得一般模式
{
    public class ZouShimingFight : AbstractFight
    {
        /// <summary>
        /// 邹市明被打时得分下降，坤比七得分上涨
        /// num表示得分，fight表示坤比七对象
        /// </summary>
        /// <param name="num"></param>
        /// <param name="fight"></param>
        public override double ChangeGrade(double num, AbstractFight fight)
        {
            this.grade -= num;
            fight.grade = fight.grade + num;
            return this.grade;
        }
    }
}
