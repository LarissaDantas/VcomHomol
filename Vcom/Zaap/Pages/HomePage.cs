using OpenQA.Selenium;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace Vcom.Pages
{
    public class HomePage : BasePage
    {
        public By button_new_register = By.XPath("/html/body/header/div/nav[1]/div[1]/a[3]");
        public By msg_request_registration = By.XPath("//*[@id='messages']/div/text()");
      

        public void GoTo(string url)
        {
            ToNavigate(url);
            Thread.Sleep(4000);

        }
        public void ToClickButtonNovoCadastro()
        {
            //Thread.Sleep(8000);
            ToClick(button_new_register);
        }
        public void ToValidateMessageRegistration()
        {
            Thread.Sleep(5000);
            Equals(msg_request_registration, "Seu cadastro foi realizado. Aguarde a revisão e aprovação da sua conta.");
        }

    }
}
