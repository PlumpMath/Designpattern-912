﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击中介者模式
{
    public class KunBiQiFight : AbstractFight
    {
        public override double ChangeGrade(double num, AbstractMediator fight)
        {
            return fight.KunEmbattled(num);
        }
    }
}
