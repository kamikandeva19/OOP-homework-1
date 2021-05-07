namespace Homework.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class SilverCard : Card
    {
        public SilverCard(Cardholder cardholder)
        {
            super(CardType.SILVER, cardholder, 2);
        }

        private void super(CardType Silver, Cardholder cardholder, int v)
        {
            throw new NotImplementedException();
        }

        public double CurrentRate()
        {
            if (getTurnover() <= 300)
            {
                return getInitialRate();
            }

            return 3.5;
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