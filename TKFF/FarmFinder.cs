using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

public struct strTab
{
    public void init_strTab()
    {
        distance = "";
        evodot = "";
        evo = "";
        coords = "";
        pop = "";
        village = "";
        player = "";
        tribe = "";
        numVillages = "";
        kingdom = "";
        action = "";
    }
    public string distance;
    public string evodot;
    public string evo;
    public string coords;
    public string pop;
    public string village;
    public string player;
    public string tribe;
    public string numVillages;
    public string kingdom;
    public string action;

}

namespace TKFF
{

    

    class FarmFinder
    {
        ChromeWrapper browser = null;
        public FarmFinder()
        {
            List<strTab> strCont = new List<strTab>();

            string x = "1";
            string y = "1";
            string village = "1";
            string vPopMin = "1";
            string vPopMax = "10000";
            string vPlaMin = "1";
            string vPlaMax = "10000";
            string vilcount = "10";
            string evoMax = "1";
            string evoMin = "1";
            bool allowRomans = true;
            bool allowGauls = false;
            bool allowTeutons = true;
            bool allowCapitals = false;


            Console.WriteLine("Hi!");
            browser = new ChromeWrapper();
            Console.WriteLine("Going to FarmFinder!");
            browser.LoadUrl("https://travian.engin9tools.com/farm-finder");
            //browser.WaitUntilElementIsPresent(By.Id("md-input-0"), 2);

            browser.clickElement(By.TagName("select"));
            IReadOnlyCollection<IWebElement> servers = browser.getElements(By.TagName("option"));
            foreach(IWebElement ele in servers)
            {
                if (ele.GetAttribute("label").Contains("com2x3.kingdoms.com")) ele.Click();
            }

            browser.typeTextBox(By.Id("mat-input-0"), x);
            browser.typeTextBox(By.Id("mat-input-1"), y);
            browser.typeTextBox(By.Id("mat-input-9"), village);
            browser.typeTextBox(By.Id("mat-input-2"), vPopMin);
            browser.typeTextBox(By.Id("mat-input-3"), vPopMax);
            browser.typeTextBox(By.Id("mat-input-4"), vPlaMin);
            browser.typeTextBox(By.Id("mat-input-5"), vPlaMax);
            browser.typeTextBox(By.Id("mat-input-6"), vilcount);
            browser.typeTextBox(By.Id("mat-input-7"), evoMax);
            browser.typeTextBox(By.Id("mat-input-8"), evoMin);

            //if (browser.WaitUntilElementIsPresent(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"), 1) != allowRomans)
            //    browser.clickElement(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"));
            //if (browser.WaitUntilElementIsPresent(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"), 1) != allowGauls)
            //    browser.clickElement(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"));
            //if (browser.WaitUntilElementIsPresent(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"), 1) != allowTeutons)
            //    browser.clickElement(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"));
            //if (browser.WaitUntilElementIsPresent(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"), 1) != allowcapitals)
            //    browser.clickElement(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"));
            IWebElement aRomans = browser.getElement(By.Id("mat-checkbox-1"));
            IWebElement aGauls = browser.getElement(By.Id("mat-checkbox-2"));
            IWebElement aTeutons = browser.getElement(By.Id("mat-checkbox-3"));
            IWebElement aCapitals = browser.getElement(By.Id("mat-checkbox-4"));

            Console.WriteLine(aRomans.GetAttribute("className"));
            Console.WriteLine(aRomans.GetAttribute("className").Contains("mat-checkbox-checked"));
            if (aRomans.GetAttribute("className").Contains("mat-checkbox-checked") != allowRomans)
            {
                browser.clickElement(By.Id("mat-checkbox-1"));
            }
            if (aGauls.GetAttribute("className").Contains("mat-checkbox-checked") != allowGauls)
            {
                browser.clickElement(By.Id("mat-checkbox-2"));
            }
            if (aTeutons.GetAttribute("className").Contains("mat-checkbox-checked") != allowTeutons)
            {
                browser.clickElement(By.Id("mat-checkbox-3"));
            }
            if (aRomans.GetAttribute("className").Contains("mat-checkbox-checked") != allowCapitals)
            {
                browser.clickElement(By.Id("mat-checkbox-4"));
            }

            browser.clickElement(By.ClassName("mat-raised-button"));

            Thread.Sleep(1000);
            IReadOnlyCollection<IWebElement> table = browser.getElements(By.TagName("tr"));
            foreach (IWebElement row in table)
            {
                IReadOnlyCollection<IWebElement> atoms = row.FindElements(By.TagName("td"));
                int i = 0;
                strTab tmp = new strTab();
                tmp.init_strTab();
                foreach (IWebElement atom in atoms)
                {
                    switch (i)
                    {
                        case 0:
                            tmp.distance = atom.Text;
                            break;
                        case 1:
                            tmp.evodot = atom.Text;
                            break;
                        case 2:
                            tmp.evo = atom.Text;
                            break;
                        case 3:
                            tmp.coords = atom.Text;
                            break;
                        case 4:
                            tmp.pop = atom.Text;
                            break;
                        case 5:
                            tmp.village = atom.Text;
                            break;
                        case 6:
                            tmp.player = atom.Text;
                            break;
                        case 7:
                            tmp.tribe = atom.Text;
                            break;
                        case 8:
                            tmp.numVillages = atom.Text;
                            break;
                        case 9:
                            tmp.kingdom = atom.Text;
                            break;
                        case 10:
                            tmp.action = atom.Text;
                            break;
                        default:
                            Console.WriteLine("table content undefined");
                            break;


                    }

                    i++;
                }

                strCont.Add(tmp);
            }
        }


    }
}
