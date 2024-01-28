long timestamp = 1706343583;
DateTime dataHora = DateTimeOffset.FromUnixTimeSeconds(1706343583).UtcDateTime;
var quantHora = dataHora.AddHours(-12);
Console.WriteLine($"Valor do TimeStamp:  {timestamp}");
Console.WriteLine($"Convertendo para Data:  {quantHora.ToString("dd/MM/yyyy HH:mm:ss")}");