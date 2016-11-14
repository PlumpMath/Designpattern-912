using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击中介者模式
{
    /// <summary>
    /// 拳击者得类包括得分，和受到攻击时得分变化得方法
    /// </summary>
    public abstract class AbstractFight
    {
        //得分
        public double grade;
        /// <summary>
        /// 受到打击时或者主动出击时得分得变化
        /// </summary>
        /// <param name="num"></param>
        /// <param name="fight"></param>
        public abstract double ChangeGrade(double num, AbstractMediator fight);
    }
}
