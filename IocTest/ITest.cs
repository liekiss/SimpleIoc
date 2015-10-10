using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocTest
{
    public interface ITest
    {
        string Name { get; set; }
        void Do();
    }

    public class Test : ITest
    {
        public string Name { get; set; }
        public void Do()
        {
            Console.WriteLine("hello" + Name);
        }
    }
}
