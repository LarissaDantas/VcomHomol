using Vcom.Pages;
using System.Configuration;
using TechTalk.SpecFlow;
using System;

namespace Vcom.VcomCob.Steps
{
    [Binding]
    public class VcomCobSteps : BasePage
    {
        

        public HomePage HomePage { get; private set; }
        public RegisterPage RegisterPage { get; private set; }

        public VcomCobSteps()
        {
            HomePage = new HomePage();
            RegisterPage = new RegisterPage();

        }

        
        
    }
}
