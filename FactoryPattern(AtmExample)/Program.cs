// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Enter your Card Type");
// visa
//master
string type = Console.ReadLine();
DebitCard obj= Cards.GetCard(type);

Console.WriteLine(obj.GetCardName());
Console.ReadLine();
Console.WriteLine("Thanks for using this application....");


// FactoryClass

class Cards
{
    public static DebitCard GetCard(string typeofoCard)
    {
        DebitCard dbcard = null;
        if (typeofoCard.ToLower()== "visa")
        {
            dbcard = new VisaDebitCard();
            dbcard.GetCardName();

        }
        if (typeofoCard.ToLower() == "master")
        {
            dbcard = new MasterDebitCard();
            dbcard.GetCardName();

        }
        if (typeofoCard.ToLower() == "cashDebit")
        {

            dbcard = new CashDebitCard();
            dbcard.GetCardName();
        }
        
        return dbcard;

    }

    
}




public interface DebitCard
{
    string GetCardName();

}

public class VisaDebitCard:DebitCard
{
    public string GetCardName()
    {
        return "Visa Debit Card";
    }

}


public class MasterDebitCard:DebitCard
{
    public string GetCardName()
    {
        return "Master Debit Card";
    }

}

public class CashDebitCard : DebitCard
{
    public string GetCardName()
    {
        return "Cash Debit Card";
    }

}