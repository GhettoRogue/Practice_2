var purchases = new List<int> { 40, 60, 80, 100 };

var account = 0;
foreach (var purchase in purchases)
{
    account += purchase;
    Console.WriteLine($"Обслужен клиент на сумму {purchase}$");
    Console.WriteLine($"Текущий баланс: {account}$");
    Console.ReadKey();
    Console.Clear();
}

Console.WriteLine("Очередь клиентов обслужена!");
Console.WriteLine($"Итоговый баланс: {account}$");