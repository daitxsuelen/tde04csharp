//string cor = "vermelho";
//
//switch (cor)
//{
 //   case "vermelho":
 //   Console.WriteLine("A cor é vermelho");
 //   break;
 //   case "azul":
 //   Console.WriteLine("A cor é azul");
 //   break;
 //   default:
 //   Console.WriteLine("Cor não encontrada!");
 //   break;

//}


//for (int i = 0; i <5; i++)
//{
//    Console.WriteLine($"Indice: {i}");
//}

//int contador = 0;
//while (contador <5);
//{
//    Console.WriteLine($"Contador: {contador}");
//    contador++;
//}
//
//int contador = 0;
//do{
//    Console.WriteLine($"Contador: {contador}");
//}while(contador <5);


//for (int i = 0; i <=10; i++)
//{
//    if(i ==5)
//    {
//        break
//    }
//    Console.WriteLine("Valor: " + i);
//
//}

double totalPedido = 0;
bool pedidoAberto = true;
while(pedidoAberto)
{
    Console.WriteLine("Bem vindo ao sistema de gerenciamento de pedidos");
    Console.WriteLine("1- Adicionar item ao pedido:");
    Console.WriteLine("2- Exibir total do pedido");
    Console.WriteLine("3- Finalizar pedido e sair");
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
       Console.WriteLine("Escolha um item abaixo");
       Console.WriteLine("1 - Pizza R$ 30,00 ");
       Console.WriteLine("2 - Hambúrguer R$ 15,00");
       Console.WriteLine("3 - Refrigerante R$ 5,00");
       string escolha = Console.ReadLine (); 
       if(escolha == "1")
       {
        totalPedido = totalPedido += 30.00;
        Console.WriteLine("Pizza adicionado ao pedido!");
       }
       else if(escolha == "2")
       {
        totalPedido = totalPedido += 15.00;
        Console.WriteLine("Hamburguer adicionado ao pedido!");
       }
       else if(escolha == "3")
       {
        totalPedido = totalPedido += 5.00;
        Console.WriteLine("Refrigerate adicionado ao pedido!");
       }
       else{
        Console.WriteLine("Opção inválida!");
       }
       break;
       case "2":
       Console.WriteLine($"O total do pedido é: {totalPedido}");
       break;
       case "3":
       Console.WriteLine($"Obrigado por utilizar nosso sistema!");
       pedidoAberto = false;
       break;
       default:
       Console.WriteLine("Opção inválida!");
       break;
    }
}
