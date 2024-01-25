using FinalAutoFrameWork.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAutoFrameWork.L3_Pages
{
    public class CommonPage
    {


        ShareStateObjects sso;
        public CommonPage(ShareStateObjects xsso)
        {
            this.sso = xsso;
        }


        public void NavigatetoPage(string url)
        {
            sso.driver.Url = url;
        }
    }
}
