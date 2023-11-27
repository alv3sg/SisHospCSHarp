using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeHospedagem.Models
{
    public class Reserva
    {
        public Reserva(List<Pessoa> hospedes, Suite suite, int qtdDIas)
        {
            this.hospedes = hospedes;
            this.suite = suite;
            this.qtdDias = qtdDIas;
            AdicionarHospede();
            while(true)if (!MenuInterativo()) break;            
        }
        List<Pessoa> hospedes;
        Suite suite;
        int qtdDias;

        public bool MenuInterativo(){
            
                Console.WriteLine("Opções de menu: \n 1 - Obter Quantidade de hospedes; \n 2 - Listar hospedes; \n 3 - Saber valor da diaria \n Outro numero - Exit");
                string res = Console.ReadLine();
                if (res == "1")
                {
                    Console.WriteLine($"A quantidade de hospedes é: {ObterQuantidadeHospedes()}");
                    return true;
                }
                if (res == "2")
                {
                    ListarHospedes();                    
                    return true;

                }
                if (res == "3")
                {
                    Console.WriteLine($"Esse é o preço final: {Preco()}");
                    return true;

                }
                else return false;
            
        }
        public void AdicionarHospede()
        {       
            //testando capacidade da suite     
            if(hospedes.Count > suite.Capacidade)
            {
                throw new Exception("A suite já está em sua capacidade maxima");
            }
            
            suite.Ocupacao =+ hospedes.Count;            

            Console.WriteLine($"Reserva realizada");
        }
        public void ListarHospedes()
        {
            hospedes.ForEach(hospede => Console.WriteLine($"A quantidade de hospedes é: {hospede.NomeCompleto}"));
        }
        public object ObterQuantidadeHospedes()
        {
            return hospedes.Count();
        }
        public decimal Preco()
        {
            decimal preco = qtdDias * suite.ValorDaDiaria;
            if(qtdDias>9)
            {
                decimal desconto = 0.25m * preco;
                preco = preco - desconto;
            }

            return preco;
            
        }
    }
}