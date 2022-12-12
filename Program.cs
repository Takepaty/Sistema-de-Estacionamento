using DesafioFundamentos.Models;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial:");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

var estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty; //string.Empty é a mesma coisa que ""
bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção");
  Console.WriteLine("1 - Cadastrar veículo");
  Console.WriteLine("2 - Remover veículo");
  Console.WriteLine("3 - Listar veículo");
  Console.WriteLine("4 - Encerrar");

  switch (Console.ReadLine())
  {
    case "1":
      estacionamento.AdicionarVeiculo();
      break;

    case "2":
      estacionamento.RemoverVeiculo();
      break;

    case "3":
      estacionamento.ListarVeiculos();
      break;

    case "4":
      exibirMenu = false;
      break;

    default:
      Console.WriteLine("Opção inválida!");
      break;
  }

  Console.WriteLine("Pressione uma tecla para continuar");
  Console.ReadLine();
}

Console.WriteLine("O programa se encerrou!");
