﻿using Back_End_ER04.Classes;
using Back_End_ER05.Classes;

List<PessoaJuridica> listaPj = new List<PessoaJuridica>();


string? opcao;
string? opcaoPj;

Utils.BarraCarregamento("Inicializando");
Console.Clear();

Console.WriteLine(@$"
            =================================================
            |      Bem Vindo ao Sistema de Cadastro de      |
            |            Pessoa Física e Juridíca           |
            =================================================
");
Thread.Sleep(2000);



do
{
    Console.Clear();
    Console.WriteLine(@$"
            =================================================
            |        Digite uma das opções abaixo           |
            |        e tecle Enter para continuar           |
            =================================================
            |                                               |
            |             1 - Pessoa Jurídica               |
            |             2 - Pessoa Fisíca                 |
            |                                               |
            |             0 - Sair                          |
            =================================================
");

    opcao = Console.ReadLine();
    //Console.WriteLine($"Você digitou: {opcao}");

    switch (opcao)
    {
        case "1":

            do
            {

                Console.Clear();
                Console.WriteLine(@$"
            =================================================
            |   Digite o número de uma das opções abaixo:   |
            =================================================
            |                                               |
            |        1 - Cadastrar Pessoa Jurídica          |
            |        2 - Listar Pessoa Jurídica             |
            |                                               |
            |        0 - Voltar ao menu anterior            |
            =================================================
");

                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":

                        PessoaJuridica novaPJ = new PessoaJuridica();
                        Endereco novoEndPJ = new Endereco();

                        Console.Clear();
                        Console.WriteLine($"Digite o nome da Razão Social");
                        novaPJ.razaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o CNPJ da empresa");
                        novaPJ.cnpj = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento da empresa");
                        string? rendEntrada = Console.ReadLine();

                        float.TryParse(rendEntrada, out float rendConvertido);
                        novaPJ.rendimento = rendConvertido;

                        //****************************************************

                        Console.WriteLine($"Digite o nome da Rua.");
                        novoEndPJ.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero do imóvel.");
                        string? numEntrada = Console.ReadLine();
                        int.TryParse(numEntrada, out int numConvertido);
                        novoEndPJ.numero = numConvertido;

                        novaPJ.endereco = novoEndPJ;
                        listaPj.Add(novaPJ);

                        Console.WriteLine($"Cadastro realizado com sucesso.");
                        Console.WriteLine($"Pressione qualquer tecla para continuar");
                        Console.ReadLine();

                        //     novaPJ.nome = "Empresa Adriano Malagoli ME";
                        //     novaPJ.cnpj = "76.773.415/0001-60";
                        //     novaPJ.rendimento = 22600.5f;

                        //     novaEndPJ.logradouro = "Rua Niteroi";
                        //     novaEndPJ.numero = 180;
                        //     novaEndPJ.complemento = "Adriano Informatica";
                        //     novaEndPJ.endComercial = false;

                        //     novaPJ.endereco = novaEndPJ;


                        // Console.WriteLine($"comandos para cadastrar uma nova pessoa jurídica");
                        //Thread.Sleep(2000);

                        break;

                    case "2":

                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPj in listaPj)
                        {

                            Console.Clear();


                            Console.WriteLine(@$"
                        Nome da Razão Social: {cadaPj.razaoSocial}
                        Endereço: {cadaPj.endereco.logradouro}, Num: {cadaPj.endereco.numero}
                        CNPJ: {cadaPj.cnpj} - Valido: {cadaPj.ValidarCnpj(cadaPj.cnpj)}
                        ");

                            Console.WriteLine($"Pressione qualquer tecla para continuar");
                            Console.ReadLine();
                        }    
                        } else
                        {
                            Console.WriteLine($"Não temos dados para exibir, listagem vazia.");
                            Thread.Sleep(4000);
                        }

                        break;



                    case "0":
                        Console.WriteLine($"Volta ao menu anterior");

                        break;

                    default:
                        Console.WriteLine($"Digite o valor correto!");
                        Thread.Sleep(2000);

                        break;
                }

            } while (opcaoPj != "0");


            //     // DADOS DA PESSOA JURIDICA ************************************************************


            //     //Console.WriteLine(novaPJ.ValidarCnpj("76773415000160"));
            //     //Console.WriteLine(novaPJ.ValidarCnpj("76.773.415/0001-60"));

            //     novaPJ.nome = "Empresa Adriano Malagoli ME";
            //     novaPJ.cnpj = "76.773.415/0001-60";
            //     novaPJ.rendimento = 22600.5f;

            //     novaEndPJ.logradouro = "Rua Niteroi";
            //     novaEndPJ.numero = 180;
            //     novaEndPJ.complemento = "Adriano Informatica";
            //     novaEndPJ.endComercial = false;

            //     novaPJ.endereco = novaEndPJ;

            //     //interpolação
            //     Console.WriteLine(@$"
            // Nome: {novaPJ.nome}
            // Endereço: {novaEndPJ.logradouro}, Num: {novaEndPJ.numero}
            // CNPJ: {novaPJ.cnpj} - Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
            // ");

            //     // Pessoa Juridica =========================================================================
            //     //Console.WriteLine(novaPJ.CalcularImposto(6600.5f));
            Thread.Sleep(2000);
            break;

        case "2":
            //DADOS DA PESSOA FISICA ************************************************************

            PessoaFisica novaPF = new PessoaFisica();
            Endereco novoEndPF = new Endereco();

            novaPF.nome = "Adriano Malagoli";
            novaPF.cpf = "2514521452";
            novaPF.rendimento = 6600.5f;
            novaPF.dataNasc = new DateTime(2001, 01, 01);

            novoEndPF.logradouro = "Rua Niteroi";
            novoEndPF.numero = 180;
            novoEndPF.complemento = "Senai Informatica";
            novoEndPF.endComercial = true;

            novaPF.endereco = novoEndPF;

            //interpolação
            Console.WriteLine(@$"
        Nome: {novaPF.nome}
        Endereço: {novoEndPF.logradouro}, Num: {novoEndPF.numero}
        Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
        ");

            // Pessoa Fisica =======================================================================
            //float impostaPagar = novaPF.CalcularImposto(novaPF.rendimento);
            //Console.WriteLine($"{impostaPagar:0.00}");
            //Console.WriteLine(impostaPagar.ToString("C"));
            //DateTime temp = new DateTime(2006, 01, 01);
            //Console.WriteLine(novaPF.ValidarDataNasc("2005/02/01"));


            Console.WriteLine($"Pressione qualquer tecla para continuar");
            Console.ReadLine();
            break;

        case "0":
            Utils.BarraCarregamento("Finalizando");
            Console.Clear();
            break;


        default:
            Console.WriteLine($"digite o valor correto");
            Thread.Sleep(2000);
            break;
    }

} while (opcao != "0");


//********************************************************
