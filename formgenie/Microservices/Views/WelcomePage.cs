using System;
using Xamarin.Forms;

namespace formgenie.Microservices.Views
{
    public class WelcomePage : TabbedPage
    {
        public WelcomePage()
        {
            var navigationPage = new NavigationPage(new DefaultScreen());
            navigationPage.Icon = "Browse.png";
            navigationPage.Title = "Welcome";

            var assessmenPage = new NavigationPage(new AvailableAssessmentList());
            assessmenPage.Icon = "Assessment.png";
            assessmenPage.Title = "Assessment";

            Children.Add(navigationPage);
            Children.Add(assessmenPage);
        }

    }
}
 