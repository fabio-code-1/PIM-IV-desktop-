using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamentoDesktop
{
    public class Pessoa
    {
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }

        // Campos para faltas, presenças e atestados
        public int Faltas { get; set; }
        public int Presencas { get; set; }
        public int Atestados { get; set; }

        public List<DateTime> DatasPresenca { get; set; } = new List<DateTime>();
        public List<DateTime> DatasAtestado { get; set; } = new List<DateTime>();
        public List<DateTime> DatasFalta { get; set; } = new List<DateTime>();
        public bool IsSelected { get; set; }
    }
}
