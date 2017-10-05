using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TKFF
{
    class FarmFinder
    {
        ChromeWrapper browser = null;
        public FarmFinder()
        {
            string x = "1";
            string y = "1";
            string village = "1";
            string vPopMin = "1";
            string vPopMax = "1";
            string vPlaMin = "1";
            string vPlaMax = "1";
            string vilcount = "1";
            string evoMax = "1";
            string evoMin = "1";
            bool allowRomans = true;
            bool allowGauls = true;
            bool allowTeutons = true;
            bool allowcapitals = true;


            Console.WriteLine("Hi!");
            browser = new ChromeWrapper();
            Console.WriteLine("Going to FarmFinder!");
            browser.LoadUrl("https://travian.engin9tools.com/farm-finder");
            browser.typeTextBox(By.Id("md_input-0"), x);
            browser.typeTextBox(By.Id("md_input-1"), y);
            browser.typeTextBox(By.Id("md_input-9"), village);
            browser.typeTextBox(By.Id("md_input-2"), vPopMin);
            browser.typeTextBox(By.Id("md_input-3"), vPopMax);
            browser.typeTextBox(By.Id("md_input-4"), vPlaMin);
            browser.typeTextBox(By.Id("md_input-5"), vPlaMax);
            browser.typeTextBox(By.Id("md_input-6"), vilcount);
            browser.typeTextBox(By.Id("md_input-7"), evoMax);
            browser.typeTextBox(By.Id("md_input-8"), evoMin);

            if (browser.WaitUntilElementIsPresent(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"), 1) != allowRomans)
                browser.clickElement(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"));
            if (browser.WaitUntilElementIsPresent(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"), 1) != allowGauls)
                browser.clickElement(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"));
            if (browser.WaitUntilElementIsPresent(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"), 1) != allowTeutons)
                browser.clickElement(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"));
            if (browser.WaitUntilElementIsPresent(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"), 1) != allowcapitals)
                browser.clickElement(By.ClassName("mat-checkbox mat-accent ng-valid ng-dirty ng-touched mat-checkbox-anim-unchecked-checked mat-checkbox-checked"));


            browser.clickElement(By.ClassName("mat-raised-button mat-accent"));



        }


    }
}
