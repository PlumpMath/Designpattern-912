using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击中介者模式
{
    /// <summary>
    /// 实现抽象中介者
    /// </summary>
    public class MeditorFight : AbstractMediator
    {
        public MeditorFight(AbstractFight _zouFight, AbstractFight _kunFight) : base(_zouFight, _kunFight)
        {
        }

        public override double KunEmbattled(double num)
        {
            zouFight.grade -= num;
            kunFight.grade = kunFight.grade + num;
            return zouFight.grade;
        }

        public override double ZouEmbattled(double num)
        {
            kunFight.grade -= num;
            zouFight.grade = zouFight.grade + num;
            return kunFight.grade;
        }
    }
}
