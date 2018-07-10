using System;
using System.Collections.Generic;

namespace formgenie.Data
{
    
    public static class PreventionSectionList
    {
        public static List<string> GetPreventionSectionList()
        {
            List<string> sectionList = new List<string>();
            sectionList.Add(PreventionSection.Pullets);
            sectionList.Add(PreventionSection.Biosecurity);
            sectionList.Add(PreventionSection.RodentsFliesOtherPestControl);
            sectionList.Add(PreventionSection.CleaningAndDisinfectionProducts);
            sectionList.Add(PreventionSection.RefrigerationProcedures);

            return sectionList;
        }
    }

    public static class PreventionSection
    {
        public static string Pullets = "Pullets";
        public static string Biosecurity = "Biosecurity";
        public static string RodentsFliesOtherPestControl = "RodentsFliesOtherPestControl";
        public static string CleaningAndDisinfectionProducts = "CleaningAndDisinfectionProducts";
        public static string RefrigerationProcedures = "RefrigerationProcedures";
    }


    public static class EnvironmentTestingSection
    {
        public static string EnvironmentalTesting = "EnvironmentalTesting";
        public static string TestingAfterInducedMoltingPeriod = "TestingAfterInducedMoltingPeriod";
    }

    public static class EnvironmentTestingSectionList
    {
        public static List<string> GetEnvironmentTestingSectionList()
        {
            List<string> sectionList = new List<string>();
            sectionList.Add(EnvironmentTestingSection.EnvironmentalTesting);
            sectionList.Add(EnvironmentTestingSection.TestingAfterInducedMoltingPeriod);

            return sectionList;
        }
    }

    public static class EggTestingSection
    {
        public static string EggTesting = "EggTesting";
    }

    public static class EggTestingSectionList
    {
        public static List<string> GetEggTestingSectionList()
        {
            List<string> sectionList = new List<string>();
            sectionList.Add(EggTestingSection.EggTesting);

            return sectionList;
        }
    }
}
