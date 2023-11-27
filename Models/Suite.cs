using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeHospedagem.Models
{
    public class Suite
    {
        public Suite(){}
        public Suite(string nome, int capacidade, decimal valorDaDiaria)
        {
            Nome = nome;
            Capacidade = capacidade;
            Ocupacao = 0;
            ValorDaDiaria = valorDaDiaria;
        }
        private string _nome;
        private int _capacidade;
        private decimal _valorDaDiaria;

        public string Nome 
        { 
            get => _nome; 
            set 
            { 
                if (value == "") 
                {
                    throw new Exception("O valor não pode ser vazio"); 
                }
                _nome = value;
            } 
        }
        public int Capacidade
        { 
            get => _capacidade; 
            set 
            { 
                if (value == 0) 
                {
                    throw new Exception("O valor não pode ser vazio"); 
                }
                _capacidade = value;
            } 
        }
        public decimal ValorDaDiaria 
        { 
            get => _valorDaDiaria; 
            set 
            { 
                if (value == 0) 
                {
                    throw new Exception("O valor não pode ser vazio"); 
                }
                _valorDaDiaria = value;
            } 
        }
        public int Ocupacao { get; set; }

    }
}