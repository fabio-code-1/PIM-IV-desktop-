using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace FolhaPagamentoDesktop
{
    /// <summary>
    /// Lógica interna para Detalhes.xaml
    /// </summary>
    public partial class Detalhes : Window
    {
         private Pessoa pessoaSelecionada;
        public Detalhes(Pessoa pessoa)
        {
            InitializeComponent();
            pessoaSelecionada = pessoa;
            // Preencha os campos da janela "Detalhes" com as informações da pessoa
            if (pessoa != null)
            {
                campoCargo.Text = pessoa.Cargo;
                campoNome.Text = pessoa.Nome;
                campoEndereco.Text = pessoa.Endereco;
                campoTelefone.Text = pessoa.Telefone;
                campoRG.Text = pessoa.RG;
                campoCPF.Text = pessoa.CPF;

                campoPresenca.Text = pessoa.Presencas.ToString(); // Converta o int para string
                campoFalta.Text = pessoa.Faltas.ToString(); // Converta o int para string
                campoAtestado.Text = pessoa.Atestados.ToString(); // Converta o int para string

            }
        }


        private void CalendarDayButton_Loaded(object sender, RoutedEventArgs e)
        {
            CalendarDayButton dayButton = (CalendarDayButton)sender;
            DateTime date = (DateTime)dayButton.DataContext;
            Brush brush = DetermineColorForDate(date, pessoaSelecionada);

            if (brush != Brushes.Transparent)
            {
                Ellipse ellipse = new Ellipse
                {
                    Width = 8,
                    Height = 8,
                    Fill = brush,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                };

                dayButton.Content = new Grid();
                ((Grid)dayButton.Content).Children.Add(ellipse);
            }
        }


        private Brush DetermineColorForDate(DateTime date, Pessoa pessoa)
        {
            if (pessoa != null)
            {
                List<DateTime> datasDePresenca = pessoa.DatasPresenca;
                List<DateTime> datasDeAtestado = pessoa.DatasAtestado;
                List<DateTime> datasDeFalta = pessoa.DatasFalta;

                if (datasDePresenca.Contains(date))
                {
                    return Brushes.Green;
                }
                else if (datasDeAtestado.Contains(date))
                {
                    return Brushes.Yellow;
                }
                else if (datasDeFalta.Contains(date))
                {
                    return Brushes.Red;
                }
            }

            return Brushes.Transparent;
        }




    }
}

