Console.WriteLine("BEM VINDO!!\nDIGITE O VALOR DA CONVERÇÃO\n");

decimal valor = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\nDIGITE 1 PARA DÓLAR\nDIGITE 2 PARA EURO\nDIGITE 0 PARA SAIR\n");
bool end = true;

while (end)
{
    int convercao = Convert.ToInt32(Console.ReadLine());

    if (convercao == 0)
    {
        Console.WriteLine("\nSAINDO DO SISTEMA...");
        end = false;
    }

    else if (convercao == 1)
    {
        valor = valor / 5.46m;
        valor = Math.Round(valor, 2);
        Console.WriteLine($"\nVOCÊ ESCOLHEU DOLAR!\nTOTAL = ${valor}");
        end = false;
    }
    else if (convercao == 2)
    {
        valor = valor / 5.84m;
        valor = Math.Round(valor, 2);
        Console.WriteLine($"\nVOCÊ ESCOLHEU EURO!\nTOTAL = {valor}");
        end = false;
    }
    else
    {
        Console.WriteLine("\nNÚMERO NÃO RECONHECIDO...\nDIGITE 1 OU 2 PARA ESCOLHER A CONVERÇÃO");
        Console.WriteLine("OU DIGITE 0 PARA SAIR");
    }
}

Console.ReadKey();