using Back_End_ER04.Classes;

// PessoaFisica novaPF = new PessoaFisica();
// Endereco novoEndPF = new Endereco();

PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novaEndPJ = new Endereco();

// DADOS DA PESSOA JURIDICA ************************************************************

//Console.WriteLine(novaPJ.ValidarCnpj("76773415000160"));
//Console.WriteLine(novaPJ.ValidarCnpj("76.773.415/0001-60"));

novaPJ.nome = "Empresa Adriano Malagoli ME";
novaPJ.cnpj = "76.773.415/0001-60";
novaPJ.rendimento = 22600.5f;

novaEndPJ.logradouro = "Rua Niteroi";
novaEndPJ.numero = 180;
novaEndPJ.complemento = "Adriano Informatica";
novaEndPJ.endComercial = false;

novaPJ.endereco = novaEndPJ;

//interpolação
Console.WriteLine(@$"
Nome: {novaPJ.nome}
Endereço: {novaEndPJ.logradouro}, Num: {novaEndPJ.numero}
CNPJ: {novaPJ.cnpj} - Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
");




// DADOS DA PESSOA FISICA ************************************************************
// novaPF.nome = "Adriano Malagoli";
// novaPF.cpf = "2514521452";
// novaPF.rendimento = 6600.5f;
// novaPF.dataNasc = new DateTime(2001, 01, 01);

// novoEndPF.logradouro = "Rua Niteroi";
// novoEndPF.numero = 180;
// novoEndPF.complemento = "Senai Informatica";
// novoEndPF.endComercial = true;

// novaPF.endereco = novoEndPF;

// //interpolação
// Console.WriteLine(@$"
// Nome: {novaPF.nome}
// Endereço: {novoEndPF.logradouro}, Num: {novoEndPF.numero}
// Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
// ");

//********************************************************



// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem vindo");

// concatenação 
// Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
// Console.WriteLine($"Bem vindo: {novaPF.nome} de Cpf: {novaPF.cpf}");

// // Pessoa Fisica =======================================================================
// float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine($"{impostaPagar:0.00}");
// Console.WriteLine(impostaPagar.ToString("C"));

// // Pessoa Juridica =========================================================================
// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));


// DateTime temp = new DateTime(2006, 01, 01);
// Console.WriteLine(novaPF.ValidarDataNasc("2005/02/01"));





