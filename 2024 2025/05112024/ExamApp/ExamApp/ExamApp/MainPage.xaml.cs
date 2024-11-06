using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamApp
{
    public class HouseInMountains
    {
        static int likes = 0;

        public static int Likes
        {
            get => likes;
            set { likes = value; }
        }
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HandleButtonClicked(object sender, EventArgs e)
        {
            var clickedBtn = sender as Button;

            if (clickedBtn == LikeButton)
                HouseInMountains.Likes++;
            else if (clickedBtn == DislikeButton)
                HouseInMountains.Likes--;
        }
    }
}
