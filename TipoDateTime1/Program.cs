Console.WriteLine("## Struct DateTime ##");

//mostra a data atual do computador, se o sistema estiver em inglês vai mostrar em inglês.
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//criar uma data especifica usa o formato: aaaa, mm, dd
DateTime dataHoje = new DateTime(2023, 09, 25);
Console.WriteLine(dataHoje);

//definir as horas
DateTime dataHoraHoje = new DateTime(2023, 09, 24, 16, 14, 30);
Console.WriteLine(dataHoraHoje +"\n");

//extrair informações da data atual
Console.WriteLine("Extraindo informações individuais: ");
DateTime hoje = DateTime.Now;
Console.WriteLine(hoje.Year        +  " Ano");
Console.WriteLine(hoje.Month       +  " Mês");
Console.WriteLine(hoje.Day         +  " Dia");
Console.WriteLine(hoje.Hour        +  " Hora");
Console.WriteLine(hoje.Minute      +  " Minuto");
Console.WriteLine(hoje.Second      +  " Segundos");
Console.WriteLine(hoje.Millisecond +  " Millisegundos \n");

//adicionando valores
Console.WriteLine("Adicionando valores:");
Console.WriteLine(hoje.AddDays(30)   + " Adicionou + 30 dias");
Console.WriteLine(hoje.AddMonths(1)  + " Adicionou + 1 mês");
Console.WriteLine(hoje.AddHours(2)   + " Adicionou + 2 horas");
Console.WriteLine(hoje.AddYears(5)   + " Adicionou + 5 anos \n");

//obter o dia da semana e do ano
Console.WriteLine("Obter o dia da semana e do ano");
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//data no formato longo e curto
Console.WriteLine("\nData no formato longo e curto");
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();