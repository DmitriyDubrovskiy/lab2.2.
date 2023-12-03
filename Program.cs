class Program
{
    static void Main()
    {
        // Створення екземпляру класу Converter з курсами валют
        Converter converter = new Converter(26.5, 31.2, 6.9);

        // Конвертація гривні в інші валюти
        double amountInUAH = 1000;
        Console.WriteLine($"{amountInUAH} UAH = {converter.ConvertToUSD(amountInUAH)} USD");
        Console.WriteLine($"{amountInUAH} UAH = {converter.ConvertToEUR(amountInUAH)} EUR");
        Console.WriteLine($"{amountInUAH} UAH = {converter.ConvertToPLN(amountInUAH)} PLN");

        // Конвертація інших валют в гривню
        double amountInUSD = 50;
        Console.WriteLine($"{amountInUSD} USD = {converter.ConvertFromUSD(amountInUSD)} UAH");
        
        double amountInEUR = 40;
        Console.WriteLine($"{amountInEUR} EUR = {converter.ConvertFromEUR(amountInEUR)} UAH");

        double amountInPLN = 15;
        Console.WriteLine($"{amountInPLN} PLN = {converter.ConvertFromPLN(amountInPLN)} UAH");
    }
}
