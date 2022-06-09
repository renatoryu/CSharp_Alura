using _06_ByteBank;

ContaCorrente conta = new();
conta.DefinirSaldo(-10);
Console.WriteLine(conta.ObterSaldo());
