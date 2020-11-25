using Vcom.Pages;
using TechTalk.SpecFlow;
using System.Configuration;

namespace Vcom.VcomCob.Steps
{
    [Binding]
    public class CobWebSteps : BasePage
    {
        

        public HomePage HomePage { get; private set; }
        public CobWebPage CobWebPage { get; private set; }

        public CobWebSteps()
        {
            HomePage = new HomePage();
            CobWebPage = new CobWebPage();
        }

       

    }
}
