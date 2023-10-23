using LiveCharts.Wpf;
using LiveCharts;
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
using LiveCharts.Definitions.Charts;
using System.Collections.ObjectModel;

namespace FolhaPagamentoDesktop
{
    public partial class PainelRh : Window
    {

		public ObservableCollection<string> Tarefas { get; set; }

		private int proximoNumero = 1;
		public PainelRh()
        {
            InitializeComponent();
            PreencherTabela();
            PreencherGrafico();
			Tarefas = new ObservableCollection<string>();
			tarefasList.ItemsSource = Tarefas;
		}
        private void PreencherGrafico()
        {
            SeriesCollection series = new SeriesCollection
    {
        new LineSeries
        {
            Title = "Vendas Mensais",
            Values = new ChartValues<double> { 100, 120, 150, 90, 110, 130, 140, 160, 130, 110, 90, 120 }
        },
        new LineSeries
        {
            Title = "Desempenho - Vermelho",
            Fill = Brushes.Transparent,
            LineSmoothness = 0,
            PointGeometry = null,
            Stroke = Brushes.Red,
            Values = new ChartValues<double> { 80, 100, 110, 80, 90, 120, 110, 130, 100, 80, 70, 90 }
        },
        new LineSeries
        {
            Title = "Produtividade Mensais - Amarelo",
            Fill = Brushes.Transparent,
            LineSmoothness = 0,
            PointGeometry = null,
            Stroke = Brushes.Yellow,
            Values = new ChartValues<double> { 120, 140, 170, 110, 130, 140, 160, 150, 140, 120, 110, 140 }
        }
    };

            cartesianChart.Series = series;
        }





        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            // Verifique se há uma linha selecionada
            if (tabela_funcionarios.SelectedItem != null)
            {
                // Acesse o objeto Pessoa associado à linha selecionada
                Pessoa pessoaSelecionada = (Pessoa)tabela_funcionarios.SelectedItem;

                // Remova o objeto Pessoa da fonte de dados da tabela
                if (tabela_funcionarios.ItemsSource is List<Pessoa> pessoas)
                {
                    pessoas.Remove(pessoaSelecionada);
                    tabela_funcionarios.ItemsSource = null; // Limpe a fonte de dados
                    tabela_funcionarios.ItemsSource = pessoas; // Atribua a fonte de dados novamente
                }
            }
        }




        private void PreencherTabela()
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
               new Pessoa
                {
                    Cargo = "Gerente",
                    Nome = "João",
                    Endereco = "Rua A",
                    Telefone = "123456789",
                    RG = "1234",
                    CPF = "56789",
                    IsSelected = false,
                    Faltas = 3,
                    Presencas = 3,
                    Atestados = 2,
                    DatasFalta = new List<DateTime>
                    {
                        new DateTime(2023, 10, 1),
                        new DateTime(2023, 10, 5),
                        new DateTime(2023, 10, 8),
                    },
                    DatasPresenca = new List<DateTime>
                    {
                        new DateTime(2023, 10, 2),
                        new DateTime(2023, 10, 6),
                        new DateTime(2023, 10, 9),
                    },
                    DatasAtestado = new List<DateTime>
                    {
                        new DateTime(2023, 10, 3),
                        new DateTime(2023, 10, 7),
                    },
                },
                new Pessoa
                {
                    Cargo = "Analista",
                    Nome = "Maria",
                    Endereco = "Rua B",
                    Telefone = "987654321",
                    RG = "5678",
                    CPF = "98765",
                    IsSelected = false,
                    Faltas = 3,
                    Presencas = 3,
                    Atestados = 2,
                    DatasFalta = new List<DateTime>
                    {
                        new DateTime(2023, 10, 1),
                        new DateTime(2023, 10, 4),
                        new DateTime(2023, 10, 7),
                    },
                    DatasPresenca = new List<DateTime>
                    {
                        new DateTime(2023, 10, 2),
                        new DateTime(2023, 10, 5),
                        new DateTime(2023, 10, 8),
                    },
                    DatasAtestado = new List<DateTime>
                    {
                        new DateTime(2023, 10, 3),
                        new DateTime(2023, 10, 6),
                    },
                },
                new Pessoa
                {
                    Cargo = "Programador",
                    Nome = "Carlos",
                    Endereco = "Rua C",
                    Telefone = "555555555",
                    RG = "9999",
                    CPF = "44444",
                    IsSelected = false,
                    Faltas = 3,
                    Presencas = 3,
                    Atestados = 2,
                    DatasFalta = new List<DateTime>
                    {
                        new DateTime(2023, 10, 1),
                        new DateTime(2023, 10, 5),
                        new DateTime(2023, 10, 8),
                    },
                    DatasPresenca = new List<DateTime>
                    {
                        new DateTime(2023, 10, 2),
                        new DateTime(2023, 10, 6),
                        new DateTime(2023, 10, 9),
                    },
                    DatasAtestado = new List<DateTime>
                    {
                        new DateTime(2023, 10, 3),
                        new DateTime(2023, 10, 7),
                    },
                },
                new Pessoa
                {
                    Cargo = "Supervisor",
                    Nome = "Ana",
                    Endereco = "Rua D",
                    Telefone = "777777777",
                    RG = "7777",
                    CPF = "22222",
                    IsSelected = false,
                   Faltas = 3,
                    Presencas = 3,
                    Atestados = 2,
                    DatasFalta = new List<DateTime>
                    {
                        new DateTime(2023, 10, 1),
                        new DateTime(2023, 10, 5),
                        new DateTime(2023, 10, 8),
                    },
                    DatasPresenca = new List<DateTime>
                    {
                        new DateTime(2023, 10, 2),
                        new DateTime(2023, 10, 6),
                        new DateTime(2023, 10, 9),
                    },
                    DatasAtestado = new List<DateTime>
                    {
                        new DateTime(2023, 10, 3),
                        new DateTime(2023, 10, 7),
                    },
                },
                new Pessoa
                {
                    Cargo = "Estagiário",
                    Nome = "Lucas",
                    Endereco = "Rua E",
                    Telefone = "111111111",
                    RG = "1111",
                    CPF = "11111",
                    IsSelected = false,
                    Faltas = 3,
                    Presencas = 3,
                    Atestados = 2,
                    DatasFalta = new List<DateTime>
                    {
                        new DateTime(2023, 10, 1),
                        new DateTime(2023, 10, 5),
                        new DateTime(2023, 10, 8),
                    },
                    DatasPresenca = new List<DateTime>
                    {
                        new DateTime(2023, 10, 2),
                        new DateTime(2023, 10, 6),
                        new DateTime(2023, 10, 9),
                    },
                    DatasAtestado = new List<DateTime>
                    {
                        new DateTime(2023, 10, 3),
                        new DateTime(2023, 10, 7),
                    },
                }

            }; 

            tabela_funcionarios.ItemsSource = pessoas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Obtenha as entradas selecionadas
            var pessoasSelecionadas = tabela_funcionarios.SelectedItems.OfType<Pessoa>().ToList();

            // Verifique se há algo selecionado
            if (pessoasSelecionadas.Count > 0)
            {
                // Obtenha a fonte de dados
                if (tabela_funcionarios.ItemsSource is List<Pessoa> pessoas)
                {
                    foreach (var pessoaSelecionada in pessoasSelecionadas)
                    {
                        pessoas.Remove(pessoaSelecionada);
                    }

                    // Atualize a fonte de dados do DataGrid
                    tabela_funcionarios.ItemsSource = null; // Limpe a fonte de dados
                    tabela_funcionarios.ItemsSource = pessoas; // Atribua a fonte de dados novamente
                }
            }
        }


        private void Detalhes_Click(object sender, RoutedEventArgs e)
        {
            // Verifique se uma pessoa foi selecionada na tabela
            Pessoa pessoaSelecionada = tabela_funcionarios.SelectedItem as Pessoa;
            if (pessoaSelecionada != null)
            {
                // Crie uma instância da janela "Detalhes" e passe a pessoa selecionada para ela
                Detalhes detalhesWindow = new Detalhes(pessoaSelecionada);
                detalhesWindow.Show();
            }
        }

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{

        }

		private void AdicionarTarefa_Click(object sender, RoutedEventArgs e)
		{
			string novaTarefaTexto = novaTarefaTextBox.Text;

			if (!string.IsNullOrEmpty(novaTarefaTexto))
			{
				string tarefaNumerada = $"{proximoNumero}. {novaTarefaTexto}";
				Tarefas.Add(tarefaNumerada);

				proximoNumero++; // Incrementa o número para a próxima tarefa
				novaTarefaTextBox.Clear();
			}
		}

		private void RemovePlaceholder(object sender, RoutedEventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			if (textBox.Text == "Digite sua tarefa aqui...")
			{
				textBox.Text = "";
				textBox.Foreground = SystemColors.WindowTextBrush;
			}
		}

		private void AddPlaceholder(object sender, RoutedEventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			if (string.IsNullOrWhiteSpace(textBox.Text))
			{
				textBox.Text = "Digite sua tarefa aqui...";
				textBox.Foreground = Brushes.Gray;
			}
		}

	}
}

