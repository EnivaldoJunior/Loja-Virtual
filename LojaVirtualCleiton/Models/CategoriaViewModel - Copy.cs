﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaVirtualCleiton.Models
{
    public class CategoriaViewModel
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório.")]
        public string Nome { get; set; }

        public string Categoria { get; set; }
    }
} 