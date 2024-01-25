using FinalAutoFrameWork.Utilities;
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
    public class DataHooks
    {

        public static Dictionary<string, string> RegData;
        [BeforeScenario("registration")]
        public void LoadDataForReg()
        {

            string AssemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine("Assembly Path: " + AssemblyPath);
            string filename = AssemblyPath + "/../../Data/RegData.txt";
            RegData = Utils.LoadData(filename);

           

        }

    }
}
