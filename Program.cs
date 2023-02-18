using static System.Console;

CalculadoraImc();

void CalculadoraImc()
{
    WriteLine("Informe sua altura: ex: 1.80");
    var alturaValida = decimal.TryParse(ReadLine(), out decimal altura);
    WriteLine("Informe seu peso: ex: 90");
    var pesoValido = decimal.TryParse(ReadLine(), out decimal peso);

    if (alturaValida && pesoValido)
    {
        var calculoImc = CalculaImc(altura, peso);
        WriteLine($"> Seu IMC é: {calculoImc}");
        StatusPeso(calculoImc, peso);
    }
    else
    {
        WriteLine("Confira se os dados estão corretos!");
        Thread.Sleep(1000);
        Clear();
        CalculadoraImc();
    }

    ReadKey();
}

decimal CalculaImc(decimal altura, decimal peso)
    => Math.Round(peso / (altura * altura), 1);

void StatusPeso(decimal calculoImc, decimal peso)
{
    if (calculoImc < 18.5m && peso < 59.9m)
    {
        WriteLine("> Magreza");
    }
    else if (calculoImc >= 18.5m && calculoImc <= 24.9m && peso >= 59.9m && peso <= 80.7m)
    {
        WriteLine("> Normal");
    }
    else if (calculoImc >= 24.9m && calculoImc <= 30m && peso >= 80.7m && peso <= 97.2m)
    {
        WriteLine("> Sobrepeso");
    }
    else if (calculoImc > 30m && calculoImc <= 34.9m && peso > 97.2m)
    {
        WriteLine("> Obesidade Grau I");
        WriteLine("> Risco: Moderado");
    }
    else if (calculoImc > 35m && calculoImc <= 39.9m && peso > 97.2m)
    {
        WriteLine("> Obesidade Grau II");
        WriteLine("> Risco: Alto");
    }
    else if (calculoImc > 40m && peso > 97.2m)
    {
        WriteLine("> Obesidade Grau III");
        WriteLine("> Risco: Grave");
    }
}