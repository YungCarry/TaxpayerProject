using TaxpayerProject.DBModels;
using TaxpayerProject.Models;
using TaxpayerProject.Repo;

try
{
    Taxpayers noEmail = new Taxpayers("NoEmail", "", 0);
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Taxpayers Antal = new Taxpayers("Adozó Antal", "anti@gmail.com", 0);

try
{
    Antal.Increase(-200000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Antal.Increase(20000);
Antal.Decrease(-10000);

Console.WriteLine(Antal);

TaxPayerRepo repo = new();
List<Taxpayers> taxPayers = repo.GetAll();
foreach (Taxpayers t in taxPayers)
{
    Console.WriteLine(t);
}

List<Taxpayers> taxPayersMinimum = repo.GetMinimum(17000);
Console.WriteLine("\nMinimum 17000ft adojuk van: ");
foreach (Taxpayers t in taxPayersMinimum)
{
    Console.WriteLine(t);
}

List<Taxpayers> taxPayersByDesc = repo.GetAllByDesc();
Console.WriteLine("\nAdozók csökkenő sorrendben: ");
foreach (Taxpayers t in taxPayersByDesc)
{
    Console.WriteLine(t);
}
