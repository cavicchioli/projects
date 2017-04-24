﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProdutos.Model
{
    class Produto
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private decimal _preco;

        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        private int _quantidade;

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
    }
}