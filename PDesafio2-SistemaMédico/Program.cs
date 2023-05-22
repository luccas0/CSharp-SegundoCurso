using PDesafio2_SistemaMédico;

Pessoa pessoa = new Pessoa();

pessoa.nome = "Daniel";
pessoa.idade = 54;
pessoa.altura = 1.79;
pessoa.peso = 80;

Console.WriteLine("O paciente se chama " +  pessoa.nome);
Console.WriteLine("O paciente tem " + pessoa.idade + " anos de idade");
Console.WriteLine("O paciente tem " + pessoa.altura + " de altura");
Console.WriteLine("O paciente pesa " + pessoa.peso + " kilos");

Console.WriteLine("Aperte a tecla enter para sair do sistema");
Console.ReadLine();


