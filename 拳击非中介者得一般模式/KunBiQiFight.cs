using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击非中介者得一般模式
{
    public class KunBiQiFight : AbstractFight
    {
        public override double ChangeGrade(double num, AbstractFight fight)
        {
            this.grade -= num;
            fight.grade = fight.grade + num;
            return this.grade;
        }
    }
}
