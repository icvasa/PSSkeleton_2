using ATFbones.ui.drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ATFbones.ui.stepdefs.hooks
{

    class StepHooks : AbstractStepDefs
    {
        [Before]
        public void InitApplication()
        {
            BrowserFactory.LoadApplication("http://www.airmoldova.md");
        }

        [After]
        public void CloseApplication()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}
