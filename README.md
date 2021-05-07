The C# application represents a market store which provides its clients with 3 types of discount cards. With each of them you can calculate the discount of the current purchase. The structure contains a package of cards where there are three options: bronze, silver and gold. Then we have a package of cardholders, including the class CardHolder, the abstract class Card - superclass of all cards: card type, cardholder, initial discount rate, turnover for the previous month; abstract method currentRate - calculates current discount rate depending on the turnover; and the three classes – BronzeCard, SilverCard, GoldCard. Next, we have the package of paydesk, where we have class PayDesk, class Invoice and class Main. The final result of the application is it displays to the user all the information above.