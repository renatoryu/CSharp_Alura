using _06_ByteBank;

ContaCorrente conta = new();
Cliente cliente = new();
cliente.Nome = "Renato";
cliente.CPF = "412.314.323-54";
cliente.Profissao = "Desenvolvedor";


conta.Saldo = -10;
conta.Titular = cliente;
Console.WriteLine(conta.Titular.Nome);
Console.WriteLine(conta.Saldo);
