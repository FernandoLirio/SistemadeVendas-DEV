﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeVendas.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}
