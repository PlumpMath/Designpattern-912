using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    //管理
    class Manger : Position
    {
        private List<Position> manger = new List<Position>();
        public Manger(string name) : base(name)
        {
        }

        public override void AddPosition(Position postion)
        {
            manger.Add(postion);
        }
        public override void RemovePostion(Position postion)
        {
            manger.Remove(postion);
        }

        public override string DisplayPostion(int depth)
        {
            string dis = "";
            dis += new String('-', depth) + _name + '\n';
            foreach(Position p in manger)
            {
                dis += p.DisplayPostion(depth+2);
            }
            Console.WriteLine(dis);
            return dis;
        }
    }
}
