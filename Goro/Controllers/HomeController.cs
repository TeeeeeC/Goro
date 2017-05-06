namespace Goro.Controllers
{
    using Models.Home;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Assets()
        {
            var assetsViewModel = this.GetAssets();
            return this.PartialView("_Assets", assetsViewModel);
        }

        public ActionResult Solutions()
        {
            var solutionsViewModel = this.GetSolutions();
            return this.PartialView("_Solutions", solutionsViewModel);
        }

        private IList<AssetsViewModel> GetAssets()
        {
            var assets = new List<AssetsViewModel>()
            {
                new AssetsViewModel
                {
                    ImageName = "goro-icon-database-raid-white.svg",
                    Title = "Make smarter, faster decisions.",
                    Content = "Connect your people with the data they need to take action."
                },
                new AssetsViewModel
                {
                    ImageName = "goro-icon-settings-tools-configuration-preferences-white.svg",
                    Title = "Discover hidden opportunities.",
                    Content = "Find the next big opportunity in your business data."
                },
                new AssetsViewModel
                {
                    ImageName = "goro-icon-chat-message-discussion-bubble-reply-conversation-white.svg",
                    Title = "Work better. Together.",
                    Content = "Quickly arrive at consensus, act, and capitalize on opportunities."
                },
                new AssetsViewModel
                {
                    ImageName = "goro-icon-mobile-iphone-white.svg",
                    Title = "Take action—anywhere, anytime.",
                    Content = "Get from insight to action faster than ever before."
                }
            };

            return assets;
        }

        private IList<SolutionsViewModel> GetSolutions()
        {
            var solutions = new List<SolutionsViewModel>()
            {
                new SolutionsViewModel
                {
                    ImageName = "goro-icon-user-profile-avatar-man-male-1-brand-gradient.svg",
                    Title = "CEO",
                    Content = "Make the right decisions when you have the right information.",
                    ButtonName = "Learn More >"
                },
                new SolutionsViewModel
                {
                    ImageName = "goro-icon-money-usa-dollar-brand-gradient.svg",
                    Title = "Finance",
                    Content = "Keep your finger on your organization's financial pulse.",
                    ButtonName = "Learn More >"
                },
                new SolutionsViewModel
                {
                    ImageName = "goro-icon-graph-line-chart-statistics-brand-gradient.svg",
                    Title = "BI",
                    Content = "Become the information hero you were hired to be.",
                    ButtonName = "Learn More >"
                },
                new SolutionsViewModel
                {
                    ImageName = "goro-icon-settings-gears-preferences-gearbox-brand-gradient.svg",
                    Title = "Operations",
                    Content = "Arm yourself with insights that help you optimize what matters most.",
                    ButtonName = "Learn More >"
                },
                new SolutionsViewModel
                {
                    ImageName = "goro-icon-server-hosting-brand-gradient.svg",
                    Title = "IT",
                    Content = "Give people a user-friendly way to answer their own business questions.",
                    ButtonName = "Learn More >"
                },
                new SolutionsViewModel
                {
                    ImageName = "goro-icon-mobile-phone-call-ringing-nfc-brand-gradient.svg",
                    Title = "Sales",
                    Content = "Learn how Domo helps you crush your quota.",
                    ButtonName = "Learn More >"
                },
                new SolutionsViewModel
                {
                    ImageName = "goro-icon-graph-columns-growth-statistics-brand-gradient.svg",
                    Title = "Marketing",
                    Content = "Get a holistic view of everything from acquisition to win, and beyond.",
                    ButtonName = "Learn More >"
                },
                new SolutionsViewModel
                {
                    ImageName = "goro-icon-users-profile-group-couple-man-woman-brand-gradient.svg",
                    Title = "Services",
                    Content = "Customers depend on you. Get the insights to serve them well.",
                    ButtonName = "Learn More >"
                }
            };

            return solutions;
        }
    }
}