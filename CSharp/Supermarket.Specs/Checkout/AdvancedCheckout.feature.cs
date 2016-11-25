﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Supermarket.Specs.Checkout
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class OnCheckingOutAReceiptWithDetailedInformationIsPrintedFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AdvancedCheckout.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "On checking out, a receipt with detailed information is printed", "\tIn order to check that I did not pay too much\r\n\tAs a customer\r\n\tI want to see fr" +
                    "om which parts the total amount I have paid consists of.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "On checking out, a receipt with detailed information is printed")))
            {
                Supermarket.Specs.Checkout.OnCheckingOutAReceiptWithDetailedInformationIsPrintedFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Unit Price",
                        "Tax Rate"});
            table1.AddRow(new string[] {
                        "Milk 1l",
                        "1.00€",
                        "20%"});
            table1.AddRow(new string[] {
                        "Butter 250g",
                        "1.50€",
                        "20%"});
            table1.AddRow(new string[] {
                        "Gherkins 350g",
                        "3.00€",
                        "20%"});
            table1.AddRow(new string[] {
                        "Book \"Harry Potter\"",
                        "12.00€",
                        "10%"});
            table1.AddRow(new string[] {
                        "Book \"Cucumber Slicing\"",
                        "8.00€",
                        "10%"});
#line 9
 testRunner.Given("we have the following products in stock:", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scanning products with different tax rate. The tax contained in the total price i" +
            "s shown separately for each tax rate.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On checking out, a receipt with detailed information is printed")]
        public virtual void ScanningProductsWithDifferentTaxRate_TheTaxContainedInTheTotalPriceIsShownSeparatelyForEachTaxRate_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scanning products with different tax rate. The tax contained in the total price i" +
                    "s shown separately for each tax rate.", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product"});
            table2.AddRow(new string[] {
                        "Butter 250g"});
            table2.AddRow(new string[] {
                        "Book \"Cucumber Slicing\""});
#line 20
 testRunner.Given("I scan the following products at the cash desk:", ((string)(null)), table2, "Given ");
#line 25
 testRunner.When("I check out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("the receipt contains this information:", "Butter 250g              1.80€\r\nBook \"Cucumber Slicing\"  8.80€\r\n-----------------" +
                    "-------------\r\nTotal                   10.60€\r\nIncl. 10% VAT            0.80€\r\nI" +
                    "ncl. 20% VAT            0.30€", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
