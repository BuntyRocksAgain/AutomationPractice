using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Automation_Practice.API
{
    internal class CreateJSONPayload
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public List<string> Courses { get; set; }
    }
    public class Test
    {
        //public static void Main()
        //{
        //    try
        //    {
        //        CreateJSONPayload payload = new CreateJSONPayload()
        //        {
        //            Roll = 1,
        //            Name = "Soumya",
        //            Courses = new List<string>()
        //        {
        //            "Math", "Science", "English"
        //        }
        //        };
        //        string stringjson = JsonConvert.SerializeObject(payload);
        //        Console.WriteLine(stringjson);
        //        Assert.AreEqual(payload.Courses[0], "Math");
        //        Assert.AreEqual(payload.Name, "Soumya");
        //        Assert.AreEqual(payload.Roll, 1);
        //        Console.ReadLine();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Problem in validating Payload");
        //        Console.ReadLine();
        //    }

        //}
    }
}
