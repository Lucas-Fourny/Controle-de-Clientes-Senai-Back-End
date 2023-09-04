using System;

namespace SistemaBalti
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informe o nome do cliente");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Infome um endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (f) ou Pessoa Juridica (j)");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f") 
            {
                //Pessoa Fisica
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.Set_Nome(var_nome);
                pf.Set_Endereco(var_endereco);
                Console.WriteLine("Infome um CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Digite RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Set_Imposto(val_pag);
                Console.WriteLine("------Pessoa Fisica------");
                Console.WriteLine("Nome .............: " + pf.Get_Nome());
                Console.WriteLine("Endereço .........: " + pf.Get_Endereco());
                Console.WriteLine("CPF ..............: " + pf.cpf);
                Console.WriteLine("RG ...............: " + pf.rg);
                Console.WriteLine("Valor da compra...: " + pf.Get_Valor().ToString("C"));
                Console.WriteLine("Imporsto .........: " + pf.Get_Imposto().ToString("C"));
                Console.WriteLine("Total a pagar ....: " + pf.Get_Total().ToString("C"));
            }
            if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.Set_Nome(var_nome);
                pj.Set_Endereco(var_endereco);
                Console.WriteLine("Infome um CNPJ:");
                pj.Set_Cnpj(Console.ReadLine());
                Console.WriteLine("Digite IE:");
                pj.Set_Ie(Console.ReadLine());
                Console.WriteLine("Informe o valor da compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Set_Imposto(val_pag);
                Console.WriteLine("------Pessoa Juridica------");
                Console.WriteLine("Nome .............: " + pj.Get_Nome());
                Console.WriteLine("Endereço .........: " + pj.Get_Endereco());
                Console.WriteLine("CNPJ ..............: " + pj.Get_Cnpj());
                Console.WriteLine("RG ...............: " + pj.Get_Ie());
                Console.WriteLine("Valor da compra...: " + pj.Get_Valor().ToString("C"));
                Console.WriteLine("Imporsto .........: " + pj.Get_Imposto().ToString("C"));
                Console.WriteLine("Total a pagar ....: " + pj.Get_Total().ToString("C"));
            }

        }
    }
}
