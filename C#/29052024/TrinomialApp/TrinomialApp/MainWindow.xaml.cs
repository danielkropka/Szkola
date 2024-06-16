using System;
using System.Windows;
using System.Windows.Controls;

namespace TrinomialApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    enum FormType
    {
        Product,
        Canonical,
        General
    }

    class Trinomial
    {
        private double a,
            b,
            c;
        public double A
        {
            get => a;
            set
            {
                if (a == value || a == 0)
                    return;
                a = value;
            }
        }
        public double B
        {
            get => b;
            set => b = value;
        }
        public double C
        {
            get => c;
            set => c = value;
        }

        public double Delta
        {
            get => b * b - 4 * a * c;
        }

        public double P
        {
            get => -b / (2 * a);
        }

        public double Q
        {
            get => -Delta / (4 * a);
        }

        public FormType Form { get; set; }

        public int CountOfSolutions =>
            Delta > 0
                ? 2
                : Delta == 0
                    ? 1
                    : 0;
        public bool isCountOfSolutions { get; set; }
        public bool isSetOfValues { get; set; }
        public bool isVertex { get; set; }

        public double X1 => Delta >= 0 ? (-b - Math.Sqrt(Delta)) : double.NaN;
        public double X2 => Delta >= 0 ? (-b + Math.Sqrt(Delta)) : double.NaN;
        public string General => $"f(x)={a}x^2+{b}x+{c}";
        public string Product => $"f(x)={a}(x-{X1})(x-{X2})";

        public string Canonical
        {
            get
            {
                string signP = P < 0 ? "+" : "-";
                string absP = Math.Abs(P).ToString();
                string signQ = Q < 0 ? "" : "+";
                string absQ = Q.ToString();

                string formattedP = $"{signP} {absP}".Trim();
                string formattedQ = $"{signQ} {absQ}".Trim();

                if (a == 1)
                {
                    return $"f(x) = -(x {formattedP})^2 {formattedQ}";
                }
                else if (a == -1)
                {
                    return $"f(x) = (x {formattedP})^2 {formattedQ}";
                }
                else
                {
                    string absA = Math.Abs(a).ToString();
                    return a < 0
                        ? $"f(x) = {absA}(x {formattedP})^2 {formattedQ}"
                        : $"f(x) = -{a}(x {formattedP})^2 {formattedQ}";
                }
            }
        }

        public Trinomial()
        {
            a = 1;
            b = 2;
            c = 1;
            Form = FormType.General;
            isCountOfSolutions = true;
        }
    }

    public partial class MainWindow : Window
    {
        Trinomial t;

        public MainWindow()
        {
            InitializeComponent();
            t = new Trinomial();
            ShowC();
        }

        private void ShowC()
        {
            FunctionTB.Text =
                t.Form == FormType.General
                    ? t.General
                    : t.Form == FormType.Canonical
                        ? t.Canonical
                        : t.Product;
            if (t.isCountOfSolutions)
                CountOfSolutionsTB.Text = t.CountOfSolutions.ToString();
            else
                CountOfSolutionsTB.Text = string.Empty;
            /*            if(t.isSetOfValues)
                            SetOfValuesCB = t.*/
            if (t.isVertex)
                VertexTB.Text = $"W({t.P},{t.Q})";
            else
                VertexTB.Text = string.Empty;
        }

        private double ParseNumber(string t) =>
            double.TryParse(t, out double result) ? result : double.NaN;

        private void HandleFormChange(object sender, RoutedEventArgs e)
        {
            var checkedRB = sender as RadioButton;
            if (checkedRB == null || t == null)
                return;
            if (checkedRB.Name == "GeneralRB")
                t.Form = FormType.General;
            else if (checkedRB.Name == "CanonicalRB")
                t.Form = FormType.Canonical;
            else
                t.Form = FormType.Product;
            FunctionTB.Text =
                t.Form == FormType.General
                    ? t.General
                    : t.Form == FormType.Product
                        ? t.Product
                        : t.Canonical;
        }

        private void HandleTextChange(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null || t == null)
                return;
            if (textBox.Name == "aTB")
                t.A = ParseNumber(textBox.Text);
            else if (textBox.Name == "bTB")
                t.B = ParseNumber(textBox.Text);
            else
                t.C = ParseNumber(textBox.Text);
            ShowC();
        }

        private void HandleCBChange(object sender, RoutedEventArgs e)
        {
            var clickedCB = sender as CheckBox;
            if (clickedCB == null || t == null)
                return;
            if (clickedCB.Name == "CountOfSolutionsCB")
                t.isCountOfSolutions = (bool)CountOfSolutionsCB.IsChecked;
            else if (clickedCB.Name == "SetOfValuesCB")
                t.isSetOfValues = (bool)SetOfValuesCB.IsChecked;
            else
                t.isVertex = (bool)VertexCB.IsChecked;
            ShowC();
        }
    }
}
