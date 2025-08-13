using SIngleton.Example2;

MySingleton intance1 = MySingleton.GetInstance();
Console.WriteLine($"Instance 1 ID: {intance1.Id}");
MySingleton intance2 = MySingleton.GetInstance();
Console.WriteLine($"Instance 2 ID: {intance2.Id}");
MySingleton intance3 = MySingleton.GetInstance();
Console.WriteLine($"Instance 3 ID: {intance3.Id}");
