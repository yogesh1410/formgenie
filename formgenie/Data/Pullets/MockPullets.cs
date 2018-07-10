using System;
namespace formgenie.Data
{
    public class MockPullets
    {
        public static string PulletsFormModel
        {
            get{
                return @"{
  'title': 'Pullets',
  'formgroups': [
    {
      'text': 'A1',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Are chicks procured from SE-monitored breeder flocks that meet the National Poultry Improvement Plans standards for U.S. S. Enteritidis Clean status (9 CFR 145.23(d)) or equivalent standard?'
        }
      ]
    },
    {
      'text': 'A2',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Was pullet environment tested for SE when pullets are 14 to 16 weeks of age?'
        }
      ]
    },
    {
      'text': 'A3',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'IF Yes, was the testing positive?'
        }
      ]
    },
    {
      'text': 'A4',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'IF   tested positive, were eggs tested within 2 weeks of the start of egg laying?'
        }
      ]
    },
    {
      'text': 'A5',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'IF tested positive, was the  the pullet environment cleaned and disinfected, to include the following:Removal of all visible manure. Dry vleaning the positive pullet house to remove dust, feathers and old feed. Following cleaning, disinfection of positive pullet house with spray, aerosol, fumigation or another appropriate disinfection method'
        }
      ]
    }
  ]
}
                ";
            }
        }
        public MockPullets()
        {
        }
    }
}
