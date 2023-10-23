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

namespace FolhaPagamentoDesktop
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = campo_usuario.Text;
            string password = campo_senha.Password;

            if (username == "user" && password == "1234")
            {
                PainelRh painelRh = new PainelRh();
                painelRh.Show();
                this.Close(); // Feche a janela de login (MainWindow)
            }
            else
            {
                MessageBox.Show("Credenciais de login inválidas. Tente novamente.");
            }
        }


        private void campo_usuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
