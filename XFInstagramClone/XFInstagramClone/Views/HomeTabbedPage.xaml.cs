using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFInstagramClone.Views.HomeTabbedPageViews;

namespace XFInstagramClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();

            Children.Add(new HomePage());
            Children.Add(new DiscoverPage());
            Children.Add(new AddPostPage());
            Children.Add(new LikesPage());
            Children.Add(new ProfilePage());
        }
    }
}