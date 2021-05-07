namespace Homework
{
    using Homework.Cards;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private static void printInvoice(int purchaseValue, Card card)
        {
            Console.WriteLine(card.getCardType() + ":\n"
                + ($"Purchase value: {purchaseValue}") + "\n"
                + ($"Discount rate: {PayDesk.discountRate(card)}") + " %" + "\n"
                + ($"Discount: {PayDesk.discount(purchaseValue, card)}") + "\n"
                + ($"Total: {PayDesk.total(purchaseValue, card)}") + "\n");
        }
        public static void main()
        {
            Cardholder cardholder = new Cardholder("Sigizmund", "Krzhizhanovsky");
            Card card = new BronzeCard(cardholder);
            printInvoice(150, card);

            cardholder = new Cardholder("Julio", "Cortazar");
            card = new SilverCard(cardholder);
            card.setTurnover(600);
            printInvoice(850, card);

            cardholder = new Cardholder("Hermann", "Hesse");
            card = new GoldCard(cardholder);
            card.setTurnover(1500);
            printInvoice(1300, card);
        }
    }
}
