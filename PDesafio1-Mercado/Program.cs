using PDesafio1_Mercado;

Produto produto = new Produto();

produto.nome = "Chocolate Lacta";
produto.fabricante = "Lacta";
produto.codigoBarras = 1463789642;
produto.valorUnitario = 20;
produto.valorCompra = 5.00;
produto.quantidade = 3;

Console.WriteLine("Nome do produto: " + produto.nome);
Console.WriteLine("Fabricante do produto: " + produto.fabricante);
Console.WriteLine("Código de barras do produto: " + produto.codigoBarras);
Console.WriteLine("Valor unitario do produto: " + produto.valorUnitario);
Console.WriteLine("Valor da compra do produto: " + produto.valorCompra);
Console.WriteLine("Quantidade: " + produto.quantidade);
