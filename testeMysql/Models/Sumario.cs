using System;
using System.Collections.Generic;

#nullable disable

namespace testeMysql.Models
{
    public partial class Sumario
    {
        public int IdSumario { get; set; }
        public string Sumario1 { get; set; }
        public string Disciplina { get; set; }
        public int AlunosPresentes { get; set; }
        public int AlunosFalta { get; set; }
    }
}
