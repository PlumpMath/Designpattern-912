using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    //职员
    class Employee : Position
    {
        public Employee(string name) : base(name)
        {
        }

        public override void AddPosition(Position postion)
        {
            Console.WriteLine("不能添加下属职位");
        }

        public override void RemovePostion(Position postion)
        {
            Console.WriteLine("不能移除下属职位");
        }


        public override string DisplayPostion(int depth)
        {
            string dis = "";
            dis += new String('-', depth) + _name + "\n";
            Console.WriteLine(dis);
            return dis;
        }
    }
}
