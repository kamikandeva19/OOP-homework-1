namespace Homework.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BronzeCard : Card
    {
        public BronzeCard(Cardholder cardHolder)
        {
            super(CardType.BRONZE, cardHolder, 0);
        }

        private void super(CardType Bronze, Cardholder cardHolder, int v)
        {
            throw new NotImplementedException();
        }

        public double CurrentRate()
        {
            if (getTurnover() < 100)
            {
                return getInitialRate();
            }

            if (getTurnover() <= 300)
            {
                return 1;
            }

            return 2.5;
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

