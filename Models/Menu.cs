using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static sistemaDeHospedagem.Models.Suite;


namespace sistemaDeHospedagem.Models
{
    public class Menu
    {
        public Menu()
        {
            List<Suite> s1 = new List<Suite>();
            while (true)
            {
                Console.WriteLine
                (
                    "Selecione a opção desejada: \n" + 
                    " 1 - Cadastrar Suite \n" +
                    " 2 - Cadastrar Reserva \n" +
                    " Outra Tecla - Sair"
                );
                int res = Convert.ToInt32(Console.ReadLine());
                
                if(res == 1)
                {
                    
                    Console.WriteLine("Insira o nome da suite: ");
                    string nome = Console.ReadLine();
                    Suite s2 = new Suite();

                    s2.Nome = nome;
                    Console.WriteLine("Insira a capaidade da suite: ");
                    s2.Capacidade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o valor da diaria da suite: ");
                    s2.ValorDaDiaria = Convert.ToDecimal(Console.ReadLine());
                    // Console.WriteLine(s2.Nome + "" + s2.Capacidade + "" + s2.ValorDaDiaria); 
                    s1.Add(s2);
                    s1.ForEach(suites => Console.WriteLine(suites.Nome));
                }
                else
                {
                    break;
                }
            }

        }
    }
}