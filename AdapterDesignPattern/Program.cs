using AdapterDesignPattern.Adapter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();
            Console.ReadLine();
        }
    }
}
