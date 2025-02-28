﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;

        public Agencia agencia;
        public Cliente cliente;


        public Conta(long numero)
        {
            _numero = numero;
        }

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;

            if (saldo <= 10)
            {
                throw new ArgumentException("O saldo inicial deve ser superior a R$10,00");
            }
        }

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo { get => _saldo; }

        // crie o código de teste para testar o método de depósito e saque da conta

        public void Deposito(decimal valor)
        {
            if (valor > 0)
            _saldo += valor;
        }

        public decimal Saque(decimal valor)
        {
            if (_saldo - valor >= 0)
            {
                _saldo -= valor;
                return _saldo;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }

        }
    }
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        private int _anoNascimento;

        public Cliente(string nome, string cpf, int anoNascimento)
        {
            _nome = nome;
            _cpf = cpf;
            _anoNascimento = anoNascimento;
        }
    }
}
