using sistemaDeHospedagem.Models;

//Lista de hospedes
List<Pessoa> Hospedes = new List<Pessoa>();

//cadastrando hospedes
Pessoa h1 = new Pessoa(nome: "Pedro", sobrenome: "Silva");
Pessoa h2 = new Pessoa(nome: "Luis", sobrenome: "Carlos");
Pessoa h3 = new Pessoa(nome: "Jose", sobrenome: "Junior");
Pessoa h4 = new Pessoa(nome: "Maria", sobrenome: "Marina");
Pessoa h5 = new Pessoa(nome: "Maria", sobrenome: "Marina");

Hospedes.Add(h1);
Hospedes.Add(h2);
Hospedes.Add(h3);
Hospedes.Add(h4);
Hospedes.Add(h5);

//cadastrando suites
Suite s1 = new Suite(nome: "Master", capacidade: 6, valorDaDiaria: 100);
Suite s2 = new Suite(nome: "Intermedio", capacidade: 4, valorDaDiaria: 75);
Suite s3 = new Suite(nome: "Basica", capacidade: 2, valorDaDiaria: 50);

//cadastrar reserva
Reserva r1 = new Reserva(Hospedes, s2, 10);
