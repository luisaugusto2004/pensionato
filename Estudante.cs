﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
