﻿using bytebank;

ContaCorrente contaDoVitor = new ContaCorrente();

contaDoVitor.titular = "Vitor Grosskopf";
contaDoVitor.numero_agencia  = 1234;
contaDoVitor.conta = "123456-x"
contaDoVitor.saldo = 5000.15;

ContaCorrente contaDaJecika = new ContaCorrente();

contaDaJecika.titular = "Jecika Maciel";
contaDaJecika.numero_agencia  = 1123;
contaDaJecika.conta = "18542-x"
contaDaJecika.saldo = 10000.1;

Cliente vitor = new Cliente();
Cliente.nome = "Vitor Grosskopf";
Cliente.cpf = "01425232111";
Cliente.profissao = "Tecnico de Informatica";
 
ContaCorrente conta2 = new ContaCorrente();
conta2.titular = vitor;
conta2.conta = "1010-x";
conta2.numero_agencia = 1254;
conta2.saldo = 17541;


System.Console.WriteLine($"Titular {conta2.titular.nome}");
System.Console.WriteLine($"Conta {conta2.titular.conta}");
System.Console.WriteLine($"cpf {conta2.titular.cpf}");
System.Console.WriteLine($"Profissao {conta2.titular.profissao}");
System.Console.WriteLine($"Numero da agencia {conta2.titular.numero_agencia}");
System.Console.WriteLine($"Saldo {conta2.titular.saldo}");

// Console.WriteLine($"Saldo de {contaDaJecika.titular} na conta {contaDaJecika.conta}, é de {contaDaJecika.saldo}");
// Console.WriteLine($"Saldo de {contaDoVitor.titular} na conta {contaDoVitor.conta}, é de {contaDoVitor.saldo}");

// ContaDoVitor.Depositar(1000.20);

// Console.WriteLine($"Saldo do vitor na conta {contaDoVitor.conta} pós deposito, é de {contaDoVitor.saldo}");

// if(ContaDoVitor.Sacar(500.0) == true)
// {
//     Console.WriteLine($"Saldo do vitor na conta {contaDoVitor.conta} pós saque, é de {contaDoVitor.saldo}");
// }
// else{
//     Console.WriteLine("Não é póssivel realizar o saque");
// };

// ContaDoVitor.Transeferir(200, contaDaJecika);