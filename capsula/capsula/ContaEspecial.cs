﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsula
{
    class ContaEspecial: Conta
    {
        public override void debitar(double valor)
        {
            if (Saldo <= 0)

                Saldo -= (0.01 * valor) + valor;

            else
                Saldo -= valor;
        }
    }
}
