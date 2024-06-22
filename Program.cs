using System.Drawing;

Console.WriteLine("BEM VINDO!!\nDIGITE O VALOR DA CONVERÇÃO\n");

decimal valorDigitado = Convert.ToDecimal(Console.ReadLine());

while (true)
{
    Console.WriteLine("\nDIGITE 1 PARA DÓLAR\nDIGITE 2 PARA EURO\nDIGITE 3 PARA SAIR\n");
    int convercao = Convert.ToInt32(Console.ReadLine());

    switch (convercao)
    {
        case 1:
            valorDigitado = valorDigitado / 5.46m;
            valorDigitado = Math.Round(valorDigitado, 2);
            Console.WriteLine($"\nVOCÊ ESCOLHEU DOLAR!\nTOTAL = ${valorDigitado}");
            break;
        case 2:
            valorDigitado = valorDigitado / 5.84m;
            valorDigitado = Math.Round(valorDigitado, 2);
            Console.WriteLine($"\nVOCÊ ESCOLHEU EURO!\nTOTAL = {valorDigitado}");
            break;
        case 3:
            Console.WriteLine("\nSAINDO DO SISTEMA...");
            break;
        default:
            Console.WriteLine("\nNÚMERO NÃO RECONHECIDO...\nDIGITE 1 OU 2 PARA ESCOLHER A CONVERÇÃO");
            Console.WriteLine("OU DIGITE 3 PARA SAIR");
            break;
    }
    break;
}

Console.ReadKey();