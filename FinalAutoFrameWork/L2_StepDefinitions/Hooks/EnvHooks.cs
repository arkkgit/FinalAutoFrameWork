using FinalAutoFrameWork.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FinalAutoFrameWork.L2_StepDefinitions.Hooks
{
    [Binding]
    public class EnvHooks
    {

        public static Dictionary<string, string> EnvData;
        [BeforeTestRun]
        public static void LoadDataForEnv()
        {
            string envSelected = TestContext.Parameters["env"] ?? "UAT"; // shortcut if
            
            //if (envSelected != null) { envSelected = "UAT"; }
            
            string AssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine("Env Assembly Path: " + AssemblyPath);
            string filename = AssemblyPath + "/../../Environment/"+envSelected+".txt";
            Console.WriteLine("Env picked is : "+filename);
            EnvData = Utils.LoadData(filename);



        }
    }
}
