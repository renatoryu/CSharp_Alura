ContaCorrente contaGabriela = new();
contaGabriela.titular = "Gabriela";
contaGabriela.agencia = 863;
contaGabriela.numero = 863452;
contaGabriela.saldo = 100;

Console.WriteLine(contaGabriela.titular);
Console.WriteLine("Agência: " + contaGabriela.agencia);
Console.WriteLine("Número: " + contaGabriela.numero);
Console.WriteLine("Saldo: R$" + contaGabriela.saldo);