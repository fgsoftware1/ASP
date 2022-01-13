using System;
using System.Collections.Generic;

#nullable disable

namespace testeMysql.Models
{
    public partial class Transaco
    {
        public int IdTransacao { get; set; }
        public int Entidade { get; set; }
        public int Referencia { get; set; }
        public string Produto { get; set; }
        public string Data { get; set; }
        public string NomeCliente { get; set; }
    }
}
