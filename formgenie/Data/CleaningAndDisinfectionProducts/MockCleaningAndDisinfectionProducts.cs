using System;
namespace formgenie.Data
{
    public class MockCleaningAndDisinfectionProducts
    {
        public static string CleaningAndDisinfectionProducts
        {
            get{
                return @"{
  'title': 'CleaningAndDisinfectionProducts',
  'formgroups': [
    {
      'text': 'D1',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Were the proper cleaning and disinfection procedures followed  before new laying hens are added to the house or if environment or egg test was positive at any point during the life of a flock?'
        },
        {
          'type': 'LabelEditorView',
          'text': 'Comments'
        }
      ]
    }
  ]
}";
            }
        }
        public MockCleaningAndDisinfectionProducts()
        {
        }
    }
}
