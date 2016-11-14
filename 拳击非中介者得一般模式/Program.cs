using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击非中介者得一般模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFight zouFight = new ZouShimingFight();
            zouFight.grade = 100;
            AbstractFight kunFigeht = new KunBiQiFight();
            kunFigeht.grade = 100;

            Console.WriteLine("比赛开始");
            double zouGrade=zouFight.ChangeGrade(10, kunFigeht);
            double kunGrade = kunFigeht.ChangeGrade(30, zouFight);
            if (zouGrade > kunGrade)
            {
                Console.WriteLine("邹市明胜利");
            }

        }
    }
}
