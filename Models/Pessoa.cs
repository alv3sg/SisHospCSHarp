using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(){}
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private string _sobrenome;
        public string Nome
        {
            get //retornar um valor 
            {
                return _nome;
            }
            set //testando valor ao atribuir;
            {
                if (value == "")
                {
                    throw new Exception("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome 
        { 
            get //retornar um valor
            {
                return _sobrenome;
            }
            set //testando valor ao atribuir;
            {
                if( value == "")
                {
                    throw new Exception("O sobrenome não pode ser vazio");
                }
                _sobrenome = value;
            } 
        }               
        public string NomeCompleto => $"{Nome} {Sobrenome}";        
    }
}