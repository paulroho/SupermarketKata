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
    public partial class OnCheckingOutAReceiptWithUsefulInformationIsPrintedFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SimpleCheckout.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "On checking out, a receipt with useful information is printed", "\tIn order to check that I did not pay too much\r\n\tAs a customer\r\n\tI want to see fr" +
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "On checking out, a receipt with useful information is printed")))
            {
                Supermarket.Specs.Checkout.OnCheckingOutAReceiptWithUsefulInformationIsPrintedFeature.FeatureSetup(null);
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
                        "UnitPrice",
                        "VAT rate"});
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
                        "Book \"Cucumbers Slicing\"",
                        "8.00€",
                        "10%"});
#line 9
 testRunner.Given("we have the following products in stock:", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scanning just products with the same VAT rate. The amount for VAT rate contained " +
            "in the total price is shown.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On checking out, a receipt with useful information is printed")]
        public virtual void ScanningJustProductsWithTheSameVATRate_TheAmountForVATRateContainedInTheTotalPriceIsShown_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scanning just products with the same VAT rate. The amount for VAT rate contained " +
                    "in the total price is shown.", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product"});
            table2.AddRow(new string[] {
                        "Milk 1l"});
            table2.AddRow(new string[] {
                        "Gherkins 350g"});
#line 20
 testRunner.Given("I scan the following products at the cash desk:", ((string)(null)), table2, "Given ");
#line 25
 testRunner.When("I check out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("the receipt contains this information:", "\tMilk 1l         1.20€\r\n\tGherkins 350g   3.60€\r\n\t---------------------\r\n\tTotal   " +
                    "        4.80€\r\n\tIncl. 20% VAT   0.80€", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Scanning products with different VAT rate. The amount for each VAT rate contained" +
            " in the total price is shown separately.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On checking out, a receipt with useful information is printed")]
        public virtual void ScanningProductsWithDifferentVATRate_TheAmountForEachVATRateContainedInTheTotalPriceIsShownSeparately_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scanning products with different VAT rate. The amount for each VAT rate contained" +
                    " in the total price is shown separately.", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product"});
            table3.AddRow(new string[] {
                        "Butter 250g"});
            table3.AddRow(new string[] {
                        "Book \"Cucumber Slicing\""});
#line 38
 testRunner.Given("I scan the following products at the cash desk:", ((string)(null)), table3, "Given ");
#line 43
 testRunner.When("I check out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then("the receipt contains this information:", "\tButter 250g              1.80€\r\n\tBook \"Cucumber Slicing\"  8.80€\r\n\t--------------" +
                    "----------------\r\n\tTotal                   10.60€\r\n\tIncl. 10% VAT            0.8" +
                    "0€\r\n\tIncl. 20% VAT            0.30€ ", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
