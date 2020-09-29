using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace TSQLtoCAharp
{
    public class InitPost
    {
        public string Title { get; set; }
        public string aClass { get; set; }
        public string bClass { get; set; }
        public string cClass { get; set; }

    }

    class cDBConnect
    {
        public cDBConnect()
        {
         iInterface();   
        }

     public void  iInterface()
        {
            string test = File.ReadAllText(@"json.txt").ToString();
            Console.WriteLine("Text: {0}" , test);
            InitPost _InitPost = JsonConvert.DeserializeObject<InitPost>(test);
            string a = _InitPost.cClass.ToString();
            Console.WriteLine("Hello World! from cDBConnect {0] ",a);
        }
    }
}