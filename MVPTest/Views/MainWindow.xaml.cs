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
using MVPTest.Presenters;

namespace MVPTest.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string FirstNumText { get => tb_firstNum.Text; set => tb_firstNum.Text = value; }
        public string SecondNumText { get => tb_secondNum.Text; set => tb_secondNum.Text = value; }
        public string ResultText { get => (string)lb_res.Content; set => lb_res.Content = value; }

        private void Btn_div_Click(object sender, RoutedEventArgs e)
        {
            new MainPresenter(this).CalculateDiv();
        }
    }
}
