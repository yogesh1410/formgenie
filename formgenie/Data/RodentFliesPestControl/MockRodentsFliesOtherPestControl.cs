using System;
namespace formgenie.Data
{
    public class MockRodentsFliesOtherPestControl
    {
        public static string RodentsFliesOtherPestControlFormModel
        {
            get{
                return @"{
  'title': 'RodentsFliesOtherPestControl',
  'formgroups': [
    {
      'text': 'C1',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Are there mechanisms to ensure rodent monitoring either by visual inspection, mechanical traps , glueboards or other appropriate monitoring method ? '
        }
      ]
    },
    {
      'text': 'C2',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'If monitoring indicates unacceptable rodent activity within a poultry house,are appropriate methods to achieve satisfactory rodent control?'
        }
      ]
    },
    {
      'text': 'C3',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Are there mechanisms to monitor flies by spot cards, Scudder grills, or sticky traps or another appropriate monitoring method?'
        }
      ]
    },
    {
      'text': 'C4',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'When monitoring indicates unacceptable fly activity within a poultry house, are appropriate methods used to achieve satisfactory fly control?'
        }
      ]
    },
    {
      'text': 'C5',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Is debrise and vegetation inside and outside poultry house removed regularly to prevent harborage for pests?'
        }
      ]
    }
  ]
}";
            }
        }
        public MockRodentsFliesOtherPestControl()
        {
        }
    }
}
