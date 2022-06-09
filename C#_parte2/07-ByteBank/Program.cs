using _07_ByteBank;

ContaCorrente conta = new(867, 64245678);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
Console.WriteLine(conta.Agencia);
Console.WriteLine(conta.Numero);
ContaCorrente contaDaGabriela = new(567, 3246743);

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
