using PDesafio3_Pedidos;

Endereco localizacao = new Endereco();

localizacao.rua = "Rua São Joaquim";
localizacao.bairro = "Liberdade";
localizacao.cidade = "São Paulo";
localizacao.cep = "88600-000";
localizacao.numero = 540;

Cliente pessoa = new Cliente();

pessoa.nome = "Livia";
pessoa.cpf = "311.541.300-40";
pessoa.email = "livia50@gmail.com";
pessoa.endereco = localizacao;

Produto compra = new Produto();

compra.codigoProduto = 12345;
compra.descricao = "Produto em boas condições";
compra.valorUnitario = 10.00;
compra.quantidade = 5;

Produto compra2 = new Produto();

compra2.codigoProduto = 56789;
compra2.descricao = "Produto em boas condições 2";
compra2.valorUnitario = 20.00;
compra2.quantidade = 10;

Produto compra3 = new Produto();

compra3.codigoProduto = 98765;
compra3.descricao = "Produto em boas condições 3";
compra3.valorUnitario = 30.00;
compra3.quantidade = 15;

ItemPedido produto  = new ItemPedido();

produto.Quantidade = 5;
produto.numeroPedido = 100;
produto.produto1 = compra;
produto.produto2 = compra2;
produto.produto3 = compra3;

Pedido pedido = new Pedido();

pedido.numeroPedido = 100;
pedido.totalPedido = 20;
pedido.cliente = pessoa;
pedido.itemPedido = produto;

Console.WriteLine("Nome do cliente: " + pedido.cliente.nome);
Console.WriteLine("CPF do cliente: " + pedido.cliente.cpf);
Console.WriteLine("E-mail do cliente: " + pedido.cliente.email);
Console.WriteLine("Rua do cliente: " + pessoa.endereco.rua);
Console.WriteLine("Bairro do cliente: " + pessoa.endereco.bairro);
Console.WriteLine("Cidade do cliente: " + pessoa.endereco.cidade);
Console.WriteLine("CEP do cliente: " + pessoa.endereco.cep);
Console.WriteLine("Número da rua do cliente: " + pessoa.endereco.numero);
Console.WriteLine("Número do pedido: " + pedido.numeroPedido);
Console.WriteLine("Número total do pedido: " + pedido.totalPedido);
Console.WriteLine("Quantidade de itens pedidos " + pedido.itemPedido.Quantidade);
Console.WriteLine("Número do pedido" + pedido.itemPedido.numeroPedido);
Console.WriteLine("Código do produto: " + produto.produto1.codigoProduto);
Console.WriteLine("Descrição do produto: " + produto.produto1.descricao);
Console.WriteLine("Valor unitário" + produto.produto1.valorUnitario);
Console.WriteLine("Quantidade de produtos: " + produto.produto1.quantidade);
Console.WriteLine("Código do produto: " + produto.produto2.codigoProduto);
Console.WriteLine("Descrição do produto: " + produto.produto2.descricao);
Console.WriteLine("Valor unitário: " + produto.produto2.valorUnitario);
Console.WriteLine("Quantidade de produtos: " + produto.produto2.quantidade);
Console.WriteLine("Código do produto: " + produto.produto3.codigoProduto);
Console.WriteLine("Descrição do produto: " + produto.produto3.descricao);
Console.WriteLine("Valor unitário: " + produto.produto3.valorUnitario);
Console.WriteLine("Quantidade de produtos: " + produto.produto3.quantidade);

