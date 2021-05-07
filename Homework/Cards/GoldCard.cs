namespace Homework.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class GoldCard : Card
    {
        public GoldCard(Cardholder cardHolder)
        {
            super(CardType.GOLD, cardHolder, 2);
        }

        private void super(CardType Gold, Cardholder cardHolder, int v)
        {
            throw new NotImplementedException();
        }

        public double CurrentRate()
        {
            if (getTurnover() < 100)
            {
                return getInitialRate();
            }

            double rateOfGrowth = 2.5;
            double amountOfGrowth = 100;
            int maxRate = 10;

            double additionalRate = rateOfGrowth * (int)(getTurnover() / amountOfGrowth);
            double currentRate = getInitialRate() + additionalRate;

            if (currentRate > maxRate)
            {
                return maxRate;
            }

            return currentRate;
        }

        private double getInitialRate()
        {
            throw new NotImplementedException();
        }

        private int getTurnover()
        {
            throw new NotImplementedException();
        }

        public override double currentRate()
        {
            throw new NotImplementedException();
        }
    }
}
