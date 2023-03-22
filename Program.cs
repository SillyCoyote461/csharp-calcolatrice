var nl = Environment.NewLine;

Console.WriteLine("Somma");
Console.WriteLine(CalcoliHelper.GetSum(13, 12));
Console.WriteLine(CalcoliHelper.GetSum(12.5, 12.5));

Console.WriteLine($"{nl}Sottrazione");
Console.WriteLine(CalcoliHelper.GetSub(13, 12));
Console.WriteLine(CalcoliHelper.GetSub(13.5, 12.5));

Console.WriteLine($"{nl}Moltiplicazione");
Console.WriteLine(CalcoliHelper.GetForTimes(10, 4));
Console.WriteLine(CalcoliHelper.GetForTimes(5.5, 3.5));

Console.WriteLine($"{nl}Valore assoluto");
Console.WriteLine(CalcoliHelper.GetAbsolute(-5));
Console.WriteLine(CalcoliHelper.GetAbsolute(5));
Console.WriteLine(CalcoliHelper.GetAbsolute(-5.5));
Console.WriteLine(CalcoliHelper.GetAbsolute(5.5));

Console.WriteLine($"{nl}Minore");
Console.WriteLine(CalcoliHelper.GetMin(10, 2));
Console.WriteLine(CalcoliHelper.GetMin(10.3, 22.1));

Console.WriteLine($"{nl}Maggiore");
Console.WriteLine(CalcoliHelper.GetMax(10, 2));
Console.WriteLine(CalcoliHelper.GetMax(10.3, 22.1));

Console.WriteLine($"{nl}Potenza");
Console.WriteLine(CalcoliHelper.GetPow(5, 5));
Console.WriteLine(CalcoliHelper.GetPow(0, 0));
Console.WriteLine(CalcoliHelper.GetPow(-5, -2));
Console.WriteLine(1 / 2);
