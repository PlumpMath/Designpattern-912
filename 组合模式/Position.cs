using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    public abstract class Position
    {
        public string _name;
        public Position(string name)
        {
            this._name = name;
        }
        //添加职位
       public abstract void AddPosition(Position postion);
        //删除职位
       public abstract void RemovePostion(Position postion);

       public abstract string DisplayPostion(int depth);

    }
}
