using System;
namespace formgenie.Data
{
    public class MockBiosecurity
    {
        public static string BiosecurityFormModel
        {
            get{
                return @"{
  'title': 'Biosecurity',
  'formgroups': [
    {
      'text': 'B1',
      'displayorder': '1',
      'components': [
        {
            'id': 'Biosecurity.B1',
          'type': 'YesNoSwitchView',
          'text': 'Are there limits on visitors on the farm and in the poultry houses?'
        }
      ]
    },
    {
      'text': 'B2',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Are there established practices that will protect against cross contamination when equipment and personnel are moved among poultry houses?'
        }
      ]
    },
    {
      'text': 'B3',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Are there adequate measures preventing stray poultry, wild birds, cats, and other animals from entering poultry houses?'
        }
      ]
    },
    {
      'text': 'B4',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Are employees prevented from keeping birds at home?'
        }
      ]
    }
  ]
}
                ";
            }
        }
        public MockBiosecurity()
        {
        }
    }
}
