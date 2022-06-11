//using System;
using Newtonsoft.Json;
using System.Xml;

namespace AdapterDesignPattern.Adapter
{
    public class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            string returnXml = base.GetAllEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
