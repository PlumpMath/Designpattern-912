using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拳击中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFight zouFight = new ZouShimingFight();
            zouFight.grade = 100;

            AbstractFight kunFight = new KunBiQiFight();
            kunFight.grade = 100;

            //解耦
            AbstractMediator mFight =new MeditorFight(zouFight, kunFight);

            Console.WriteLine("比赛开始");
            double zouGrade=zouFight.ChangeGrade(10, mFight);
            double kunGrade = kunFight.ChangeGrade(30, mFight);

            if (zouGrade > kunGrade)
            {
                Console.WriteLine("邹市明胜利！！");
                
            }
            Console.ReadKey();

        }
    }
}
