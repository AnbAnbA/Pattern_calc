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

namespace Pattern_calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.TBone = TBOne;
            Model.TBtwo = TBTwo;
            Model.TBsim = TBsim;
            Model.TBRes = TBRes;
            CBAr.ItemsSource = Model.dataList;
        }

        private void BTRes_Click(object sender, RoutedEventArgs e)
        {
            if (Model.Res++ == 3)
            {
                TBRes.Text = "";
                MessageBox.Show("Вы не выбрали арифметическую функцию!");
            }
            else if (Model.Res++ == 2)
            {
                TBRes.Text = "";
                MessageBox.Show("Вы не указали второе число!");
            }
            else if (Model.Res++ == 1)
            {
                TBRes.Text = "";
                MessageBox.Show("Вы не указали первое число!");
            }
            else if (Model.Res++ == 0)
            {
                TBRes.Text = "";
                MessageBox.Show("Ошибка!");
            }
           
        }

        private void CBAr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Combo = CBAr.SelectedIndex;
        }
    }
}
