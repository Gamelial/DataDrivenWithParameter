using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace DataDrivenWithParameter.Utilities
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static IWebDriver driver;

        [BeforeScenario("@tag1")]
      
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario

            //driver.Quit();
        }
    }
}