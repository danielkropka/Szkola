using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileCubeApp
{
    public partial class MainPage : ContentPage
    {
        public int gamePoints { get; set; }
        int[] cubes = new int[5];

        Random rnd = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            int result = 0,
                k;
            for (int i = 0; i < cubes.Length; i++)
                cubes[i] = rnd.Next(1, 7);

            for (int i = 1; i < 7; i++)
            {
                k = HowManyExceptions(i);
                result += k > 1 ? k * i : 0;
            }

            gamePoints += result;
            Show(result);
        }

        private void Show(int points = 0)
        {
            FirstCubeImage.Source = $"a{cubes[0]}.jpg";
            SecondCubeImage.Source = $"a{cubes[1]}.jpg";
            ThirdCubeImage.Source = $"a{cubes[2]}.jpg";
            FourthCubeImage.Source = $"a{cubes[3]}.jpg";
            FifthCubeImage.Source = $"a{cubes[4]}.jpg";
            DrawResultLabel.Text = $"{points}";
            GameResultLabel.Text = $"{gamePoints}";
        }

        private void Reset()
        {
            for (int i = 0; i < cubes.Length; i++)
                cubes[i] = 0;
            gamePoints = 0;
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            Reset();
            Show();
        }

        private void DrawButton_Clicked(object sender, EventArgs e) => Draw();

        int HowManyExceptions(int number)
        {
            int result = 0;
            foreach (var cube in cubes)
                if (cube == number)
                    result++;
            return result;
        }
    }
}
