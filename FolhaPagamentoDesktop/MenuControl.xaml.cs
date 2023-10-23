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
using System.Windows.Shapes;

namespace FolhaPagamentoDesktop
{
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }

        private void MenuItem_Dashboard_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para ação "Dashboard" aqui
        }

        private void MenuItem_Pagamento_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para ação "Pagamento" aqui
        }

        private void MenuItem_Beneficiario_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para ação "Beneficiário" aqui
        }

        private void MenuItem_Estatisticas_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para ação "Estatísticas" aqui
        }

        private void MenuItem_Recrutamento_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para ação "Recrutamento" aqui
        }

        private void MenuItem_Treinamento_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para ação "Treinamento" aqui
        }

        private void MenuItem_Calculadora_Click(object sender, RoutedEventArgs e)
        {
            // Crie uma instância da janela Calculadora
            Calculadora calculadoraWindow = new Calculadora();

            // Chame o método Show() para exibir a janela
            calculadoraWindow.Show();
        }


        private void MenuItem_Desempenho_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para ação "Desempenho" aqui
        }

        private void MenuItem_Historico_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para ação "Histórico" aqui
        }




    }
}
