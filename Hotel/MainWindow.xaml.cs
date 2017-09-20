using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Hotel
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtQtdDias_TextChanged(object sender, TextChangedEventArgs e)
        {
            atualizarValor();
        }



        private void atualizarValor() {
            if (txtQtdDias.Text.Length == 0)
            {
                lblTotal.Content = "R$0,00";
                return;
            }

            double totalDiario = 0;
            int qtdDias = Convert.ToInt32(txtQtdDias.Text);

            totalDiario += radNormal.IsChecked == true ? 100 : 0;
            totalDiario += radLuxo.IsChecked == true ? 150 : 0;
            totalDiario += radSuperLuxo.IsChecked == true ? 200 : 0;

            totalDiario += chkArCondicionado.IsChecked == true ? 50 : 0;
            totalDiario += chkHidromassagem.IsChecked == true ? 40 : 0;
            totalDiario += chkWifi.IsChecked == true ? 30 : 0;

            double total = totalDiario * qtdDias;
            lblTotal.Content = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", total);
        }

        private void radNormal_Checked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }

        private void radLuxo_Checked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }

        private void radSuperLuxo_Checked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }

        private void chkArCondicionado_Checked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }

        private void chkArCondicionado_Unchecked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }

        private void chkHidromassagem_Checked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }

        private void chkHidromassagem_Unchecked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }

        private void chkWifi_Checked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }

        private void chkWifi_Unchecked(object sender, RoutedEventArgs e)
        {
            atualizarValor();
        }
    }
}