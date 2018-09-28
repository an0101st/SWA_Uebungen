using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Shared
{
    public interface IExChangeAble<T>
    {
        void Exchange(T data);
    }
}
