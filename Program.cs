using bytebank;

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


Console.WriteLine($"Saldo de {contaDaJecika.titular} na conta {contaDaJecika.conta}, é de {contaDaJecika.saldo}");
Console.WriteLine($"Saldo de {contaDoVitor.titular} na conta {contaDoVitor.conta}, é de {contaDoVitor.saldo}");

ContaDoVitor.Depositar(1000.20);

Console.WriteLine($"Saldo do vitor na conta {contaDoVitor.conta} pós deposito, é de {contaDoVitor.saldo}");

if(ContaDoVitor.Sacar(500.0) == true)
{
    Console.WriteLine($"Saldo do vitor na conta {contaDoVitor.conta} pós saque, é de {contaDoVitor.saldo}");
}
else{
    Console.WriteLine("Não é póssivel realizar o saque");
};

ContaDoVitor.Transeferir(200, contaDaJecika);