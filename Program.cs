﻿using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
        float val_pag;

            Console.WriteLine("Informe o seu nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Infome o seu endereço: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa física (f) ou juridícia (j)?");
            string var_tipo = Console.ReadLine();
            //Para pessoa física
            if(var_tipo == "f")
            {    
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Infome o seu CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe o seu RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Infome o valor de compra: ");
                //float.parse -> transforma uma string em variável do tipo float
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                
                Console.WriteLine("-------- Pessoa Física --------");

                Console.WriteLine("Nome .........:" + pf.nome);
                Console.WriteLine("Endereço .....:" + pf.endereco);
                Console.WriteLine("CPF ..........:" + pf.cpf);
                Console.WriteLine("RG ...........:" + pf.rg);
                Console.WriteLine("Valor da compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......:" + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar : " + pf.total.ToString("C"));
            }
            //Para pessoa juridíca
            if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Infome o seu CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informa a IE (Inscrição Estadual)");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Infome o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome .........: " + pj.nome);
                Console.WriteLine("Endereço .....: " + pj.endereco);
                Console.WriteLine("CNPJ .........: " + pj.cnpj);
                Console.Write("IE................: " + pj.ie);
                Console.WriteLine("Valor da compra: " + pj.valor.ToString("C"));
//ToString ->transforma o valor da variável em caracteres
                Console.WriteLine("Imposto ......:" + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar: " + pj.total.ToString("C"));


            }

        


        }
    }
}