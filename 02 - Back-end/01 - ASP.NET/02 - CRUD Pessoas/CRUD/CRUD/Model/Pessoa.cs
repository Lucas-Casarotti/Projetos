﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Model
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
    }
}