using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFInstagramClone.Models;

namespace XFInstagramClone.Views.HomeTabbedPageViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            FillInfo();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FillInfo();
        }

        public void FillInfo()
        {
            List<InstagramModel> instagramModels = new List<InstagramModel>();
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            instagramModels.Add(new InstagramModel
            {
                ProfilePicture = "ronaldo.jpg",
                Username = "ronaldo",
                PostImage = "collesium.jpg",
                PostDetail = "Güzel bir gündü...",
                PostLikeCount = "77",
                PostCommentCount = "7",
                PostTime = "15"
            });
            listPosts.BindingContext = instagramModels;
        }
    }
}