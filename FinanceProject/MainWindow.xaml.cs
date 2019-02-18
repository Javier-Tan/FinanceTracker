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

namespace FinanceProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectOverview(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new pageOverview());
        }

        private void selectBudget(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new pageBudget());
        }

        private void selectAccounts(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new pageAccounts());
        }

        private void selectExpenses(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new pageExpenses());
        }

        private void selectIncome(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new pageIncome());
        }

        private void selectRepayments(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new pageRepayments());
        }

        private void selectGoals(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new pageGoals());
        }

        private void selectDev(object sender, RoutedEventArgs e)
        {
            Content.Navigate(new pageDev());
        }
    }


}
