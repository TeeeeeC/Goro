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

        public ActionResult ClientsSayAboutUs()
        {
            var clientsSayAboutUsViewModel = this.GetClientsSayAboutUsViewModel();
            return this.PartialView("_ClientsSayAboutUs", clientsSayAboutUsViewModel);
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

        private IList<ClientsSayAboutUsViewModel> GetClientsSayAboutUsViewModel()
        {
            var clientsSayAboutUs = new List<ClientsSayAboutUsViewModel>()
            {
                new ClientsSayAboutUsViewModel()
                {
                    BackgroundImage = "general_banner_3.jpg",
                    ImageName = "logo-customer-mastercard-white.svg",
                    Content = "\"Goro allows us to make decisions in real time, so that we can make sure every dollar we spend on marketing is most effective.\"",
                    ClientName = "Curt Fournier",
                    ClientPosition = " | VP, Digital Marketing Analytics",
                    ClientImage = "avatar-customer-mastercard-curt-fournier.png",
                    BrandImage = "logo-customer-mastercard-color.svg"
                },
                new ClientsSayAboutUsViewModel()
                {
                    BackgroundImage = "natgeo_banner_1.jpg", 
                    ImageName = "logo-customer-national-geographic-white.svg",
                    Content = "\"Domo allows us to integrate multiple sources of data, so that we can find out what our ROI is in real time and make decisions to optimize.\"",
                    ClientName = "Brendan Hart",
                    ClientPosition = " | Senior Vice President, Consumer Analytics & Insights",
                    ClientImage = "avatar-customer-national-geographic-brendan-hart.png",
                    BrandImage = "logo-customer-national-geographic-color.svg"
                },
                new ClientsSayAboutUsViewModel()
                {
                    BackgroundImage = "danaher_banner_1.jpg",
                    ImageName = "logo-customer-danaher-white.svg",
                    Content = "\"Domo eliminates the process of moving data from one place to the other, empowering people to do what they should be doing which is pulling insights that can be used to improve our marketing.\"",
                    ClientName = "Peter Sanborn",
                    ClientPosition = " | Director, Digital Analytics",
                    ClientImage = "avatar-customer-danaher-peter-sanborn.png",
                    BrandImage = "logo-customer-danaher-color.svg"
                },
                new ClientsSayAboutUsViewModel()
                {
                    BackgroundImage = "dhl_banner_1.jpg",
                    ImageName = "logo-customer-dhl-white.svg",
                    Content = "\"With Domo, we’re able to visualize and derive actions on data that we didn’t have a grasp on before.\"",
                    ClientName = "Dina Bunn",
                    ClientPosition = " | Global Head of Central Operations & IT",
                    ClientImage = "avatar-customer-dhl-dina-bunn.png",
                    BrandImage = "logo-customer-dhl-color.svg"
                }
            };

            return clientsSayAboutUs;
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