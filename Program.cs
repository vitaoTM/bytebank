using bytebank;

ContaCorrente contaDoVitor = new ContaCorrente();

contaDoVitor.titular = "Vitor Grosskopf";
contaDoVitor.numero_agencia  = 1234;
contaDoVitor.conta = "123456-x"
contaDoVitor.saldo = 5000.15;

Console.WriteLine($"Saldo do vitor na conta {contaDoVitor.conta}, é de {contaDoVitor.saldo}");