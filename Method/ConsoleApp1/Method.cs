using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Method
    {
        public int MethodId { get; set; }
        public string Name  { get; set; }

        public void print (int MethodId,string Name )
        {
            Console.WriteLine("----------------------------------------------------");
            this.MethodId = MethodId;
            this.Name = Name;
            Console.WriteLine("Method Id : {0}\tName : {1} ",MethodId,Name);
        }
    }
}
