using TechTalk.SpecFlow;
using init_specflow.Drivers;

namespace init_specflow.Hooks
{
    [Binding]
    public class Hooks
    {
        
        [AfterScenario]
        public void AfterScenario()
        {
            Driver.CloseChromeBrowser();
        }
    }
}
