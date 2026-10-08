ContaCorrente conta = new ContaCorrente("Emilly", 1000);

Console.WriteLine("Saque igual ao saldo:");
conta.Saque(1000);

conta.Saldo = 1000;

Console.WriteLine("Saque maior que o saldo:");
conta.Saque(1200);

conta.Saldo = 1000;

Console.WriteLine("Saque menor que o saldo:");
conta.Saque(200);


ContaPoupanca poupanca = new ContaPoupanca("Emilly", 1000, 10);

Console.WriteLine("Conta Poupança:");
poupanca.Rendimento(10);