namespace Homework.Cards
{ 
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Card
    {
        private CardType CardType;
        private Cardholder Cardholder;
        private double InitialRate;
        private double Turnover;

        Card(CardType cardType, Cardholder cardHolder, double initialRate)
        {
            this.CardType = cardType;
            this.Cardholder = cardHolder;
            this.InitialRate = initialRate;
        }

        public abstract double currentRate();

        double getInitialRate()
        {
            return InitialRate;
        }

        Cardholder getCardholder()
        {
            return Cardholder;
        }

        double getTurnover()
        {
            return Turnover;
        }

        public void setTurnover(double turnover)
        {
            this.Turnover = turnover;
        }

        public CardType getCardType()
        {
            return CardType;
        }
    }
}
