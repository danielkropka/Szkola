using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TriangleIncrementApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock[] textBlocks;

        public MainWindow()
        {
            InitializeComponent();
            textBlocks = new TextBlock[] { ResultTBA, ResultTBB, ResultTBC };
        }

        private void HandleClickButton(object sender, RoutedEventArgs e)
        {
            var clickedBtn = (Button)sender;
            switch (clickedBtn.Name)
            {
                case "BtnPlusA":
                    changeTBValue(ResultTBA);
                    break;
                case "BtnMinusA":
                    changeTBValue(ResultTBA, false);
                    break;
                case "BtnPlusB":
                    changeTBValue(ResultTBB);
                    break;
                case "BtnMinusB":
                    changeTBValue(ResultTBB, false);
                    break;
                case "BtnPlusC":
                    changeTBValue(ResultTBC);
                    break;
                case "BtnMinusC":
                    changeTBValue(ResultTBC, false);
                    break;
            }
        }

        private void changeTBValue(TextBlock textBlock, bool increment = true)
        {
            int result = int.Parse(textBlock.Text);
            if (increment)
                textBlock.Text = $"{int.Parse(textBlock.Text) + 1}";
            else
                textBlock.Text = $"{int.Parse(textBlock.Text) - 1}";
            checkResult(textBlock);
        }

        private void checkResult(TextBlock block)
        {
            int result = int.Parse(block.Text);
            if (result == 0)
            {
                if (block.Name == "ResultTBA")
                    BtnMinusA.IsEnabled = false;
                else if (block.Name == "ResultTBB")
                    BtnMinusB.IsEnabled = false;
                else if (block.Name == "ResultTBC")
                    BtnMinusC.IsEnabled = false;
                return;
            }

            if (block.Name == "ResultTBA")
            {
                BtnMinusA.IsEnabled = true;
                BtnPlusA.IsEnabled = true;
            }
            if (block.Name == "ResultTBB")
            {
                BtnMinusB.IsEnabled = true;
                BtnPlusB.IsEnabled = true;
            }
            if (block.Name == "ResultTBC")
            {
                BtnMinusC.IsEnabled = true;
                BtnPlusC.IsEnabled = true;
            }
        }
    }
}
