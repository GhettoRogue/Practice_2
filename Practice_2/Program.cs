var purchases = new List<int> { 40, 60, 80, 100 };

var account = 0;
foreach (var purchase in purchases)
{
    account += purchase;
    Console.WriteLine($"Клиент обслужен на сумму {purchase}$");
    Console.WriteLine($"Баланс: {account}$");

    Console.ReadKey();
    Console.Clear();
}

Console.WriteLine("Клиенты обслужены!");
Console.WriteLine($"Итоговый баланс: {account}$");