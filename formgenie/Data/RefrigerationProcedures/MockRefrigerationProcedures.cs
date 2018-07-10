using System;
namespace formgenie.Data
{
    public class MockRefrigerationProcedures
    {
        public static string RefrigerationProceduresFormModel
        {
            get{
                return @"{
  'title': 'RefrigerationProcedures',
  'formgroups': [
    {
      'text': 'E1',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Are eggs are to be processed as table eggs and are not processed for the ultimate consumer within 36 hours from the time of lay  ? '
        }
      ]
    },
    {
      'text': 'E2',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'IF Yes, were the eggs held at room temperature for no more than 36 hours just prior to processing ?'
        }
      ]
    },
    {
      'text': 'C3',
      'displayorder': '1',
      'components': [
        {
          'type': 'YesNoSwitchView',
          'text': 'Are eggs held or transported at or below 45 °F ambient temperature beginning 36 hours after time of lay?'
        }
      ]
    }
  ]
}";
            }
        }
        public MockRefrigerationProcedures()
        {
        }
    }
}
