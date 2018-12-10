﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santiagoshoes.LojaVirtual.Dominio.Entidade
{
    class Produto
    {
        public int ProdutoId { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public Decimal Preco { get; set; }

        public String Categoria { get; set; }
    }
}
