namespace Homework
{
    using Homework.Cards;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class PayDesk
    {
        public static double discountRate(Card card)
        {
            if (card == null)
            {
                return 0;
            }
            return card.currentRate();
        }
        
        public static double total(double purchaseValue, Card card)
        {
            return purchaseValue - discount(purchaseValue, card);
        } 
        
        public static double discount(double purchaseValue, Card card)
        {
            return discountRate(card) / 100 * purchaseValue;
        }
    }
}
