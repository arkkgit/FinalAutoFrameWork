using FinalAutoFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAutoFrameWork.L3_Pages
{
    public class HomePage
    {

        ShareStateObjects sso;
        public HomePage(ShareStateObjects xsso)
        {
            this.sso = xsso;
        }
        public string getURL()
        {
            return sso.driver.Url;
        }
    }
}
