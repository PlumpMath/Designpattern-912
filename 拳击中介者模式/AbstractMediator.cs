using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击中介者模式
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    public abstract  class AbstractMediator
    {
        protected AbstractFight zouFight;
        protected AbstractFight kunFight;

        public AbstractMediator(AbstractFight _zouFight,AbstractFight _kunFight)
        {
            zouFight = _zouFight;
            kunFight = _kunFight;
        }
        /// <summary>
        /// 邹市明被打得分
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public abstract double ZouEmbattled(double num);
        /// <summary>
        /// 坤比七被打得分
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public abstract double KunEmbattled(double num);
    }
}
