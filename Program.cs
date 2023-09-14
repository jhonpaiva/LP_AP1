// declaração da variável que será a tomada de decisão no encerramento do loop
int? opcao = null;

do{
// criação das varíaveis de status final
string? status = null;
string? clasEtaria = null;

// Apresentação do programa
Console.WriteLine("Calculadora de IMC e idade");

// Solicitação de inserção dos dados
Console.WriteLine("Informe seu nome:");
string? nome = Console.ReadLine();

Console.WriteLine("Informe sua idade:"); //solicitação do dado que será inserido na variável 
int? idade = Convert.ToInt32(Console.ReadLine()); // definição da variável a partir da conversão dos dados inseridos em int

Console.WriteLine("Informe sua altura:");
double? altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe seu peso:");
double? peso = Convert.ToDouble(Console.ReadLine());

// definição do valor do IMC
double? imc = (peso / (altura * altura));

// definição do status atribuido ao IMC
if (imc < 17){
    status = "Muito abaixo do peso";
}
else if (imc < 18.4 && imc > 17){
    status = "Abaixo do peso";
}
else if (imc > 18.4 && imc < 25){
    status = "Peso ideal";
}
else if (imc > 25 && imc < 30){
    status = "Acima do peso";
}
else if (imc > 30 && imc < 35){
    status = "Obesidade grau I";
}
else if (imc > 35 && imc < 40){
    status = "Obesidade grau 2";
}
else if (imc > 40){
    status = "Obesidade grau 3";
}

// definição da classificação etária
if (idade < 14){
    clasEtaria = "Crianca";
}
else if (idade > 14 && idade < 20){
    clasEtaria = "Adolescente";
}
else if (idade > 20 && idade < 60){
    clasEtaria = "adulto";
}
else if (idade > 59){
    clasEtaria = "idoso";
}

// relatório de quais os status do usuário
Console.WriteLine("\nRelatório de avaliação: ");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"IMC / Status: {imc} / {status}");
Console.WriteLine($"Faixa Etária: {clasEtaria}\n");

// nova consulta?
Console.WriteLine("Deseja realizar uma nova consulta?");
Console.WriteLine("1 - SIM");
Console.WriteLine("2 - NÂO");
opcao = Convert.ToInt32(Console.ReadLine());

}while(opcao == 1);
