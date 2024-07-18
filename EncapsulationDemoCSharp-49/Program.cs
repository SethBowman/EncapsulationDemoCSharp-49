using EncapsulationDemoCSharp_49;

var seth = new Person();

seth.AddMoney(100.00);

var currentWallet = seth.CheckWallet();
Console.WriteLine(currentWallet);

seth.AddMoney(200.00);

currentWallet = seth.CheckWallet();
Console.WriteLine(currentWallet);

