// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace a_place_to_start.feature.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("A Place To Start")]
    public partial class APlaceToStartFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Start_Feature.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "A Place To Start", @"As Colin. a conscientious cuker
I want to write Cucumber features without step definitions
So that I don't have to focus on writing regular expressions.
and save time maintaining large step defination files
and spend even more time delivering valuable fetures to my stakeholders", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Getting some guidance about an undefined role")]
        public virtual void GettingSomeGuidanceAboutAnUndefinedRole()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting some guidance about an undefined role", ((string[])(null)));
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I am a Conscientious Cuker");
#line 10
 testRunner.And("I am using Cuke Salad");
#line hidden
#line 11
 testRunner.When("I write a simple feture like this:", "Feature: No Step Defs\n\tScenario: Step free access\n\t\tGiven I am a Step Free Cuker\n" +
                    "\t\tWhen I attempt to do an important thing\n\t\tThen I should see an equally importa" +
                    "nt answer", ((TechTalk.SpecFlow.Table)(null)));
#line 19
 testRunner.And("I run \'cucumber\'");
#line 20
 testRunner.Then("I should be told to define the \'Step Free Cuker\' role");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Getting some guidance about an undefined task")]
        public virtual void GettingSomeGuidanceAboutAnUndefinedTask()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting some guidance about an undefined task", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("I am a Conscientious Cuker");
#line 24
 testRunner.And("I am using Cuke Salad");
#line hidden
#line 25
 testRunner.When("I write a sample feature like this:", "Feature: No Step Defs\n\tScenario: Step free access\n\t\tGiven I am a Step Free Cuker\n" +
                    "\t\tWhen I attempt to do an important thing\n\t\tThen I should see an equally importa" +
                    "nt answer", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 33
 testRunner.And("I define a role like this:", "class StepFreeCuker : role\n{\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 39
 testRunner.And("I run \'cucumber\'");
#line 40
 testRunner.Then("I should be told to define the \'DoAnImportantThing\' task");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Getting some guidance about an unknown question")]
        public virtual void GettingSomeGuidanceAboutAnUnknownQuestion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting some guidance about an unknown question", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("I am a Conscientious Cuker");
#line 44
 testRunner.And("I am using Cuke Salad");
#line hidden
#line 45
 testRunner.When("I write a simple feature like this", "Feature: No Step Defs\n\tScenario: Step free access\n\t\tGiven I am a Step Free Cuker\n" +
                    "\t\tWhen I attempt to do an important thing\n\t\tThen I should see an equally importa" +
                    "nt answer", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 53
 testRunner.And("I define a role like this:", "class StepFreeCuker : role\n{\n\tpublic void do_the_thing()\n\t{\n\t}\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 62
 testRunner.And("I define a task like this:", "class StepFreeTask : task\n{\n\tin_order_to(\"DoAnImprtentThing\")\n\t{\n\t\tdo_the_thing()" +
                    "\n\t}\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 72
 testRunner.And("I run \'cucumber\'");
#line 73
 testRunner.Then("I should be told to define the \'SeeAnImportantAnswer\' task");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion