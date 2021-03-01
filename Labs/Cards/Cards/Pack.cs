using System;

namespace Cards
{	
	class Pack
	{
        public const int NumSuits = 4;   // Numsuits is a symbolic constant (naming a number). 
        public const int CardsPerSuit = 13; // same as above.
        private PlayingCard[,] cardPack;
        private Random randomCardSelector = new Random();

        public Pack()
        {
            cardPack = new PlayingCard[NumSuits, CardsPerSuit];  // creates new array with 4 rows, 13 columns per variables above and saves it in cardpack (declared line 9)
            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)  // Creates for loop to build the suits. Clubs and Spades values pulled from enumeration.
                for (Value value = Value.Two; value <= Value.Ace; value++) // Creates nested for loop to build the face values of the cards. Two and Ace pulled from enumeration.
                    cardPack[(int)suit, (int)value] = new PlayingCard(suit, value); // creates a new playing card (right side) and assigns it to the array element (left side)
        }

        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits); // creates suit variable of enum type Suit. Casts Suit 
            while (IsSuitEmpty(suit)) // checks if suit is empty yet.
                suit = (Suit)randomCardSelector.Next(NumSuits);
            Value value = (Value)randomCardSelector.Next(CardsPerSuit);
            while (IsCardAlreadyDealt(suit, value)) // this and next line, if card is already dealt, gives another random card.
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            PlayingCard card = cardPack[(int)suit, (int)value]; // creates or "pulls" a new card from the deck.
            cardPack[(int)suit, (int)value] = null; // removes the card from the deck.
            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;
            for (Value value = Value.Two; value <= Value.Ace; value++) // same as line 16
                if (!IsCardAlreadyDealt(suit, value)) // checks for any cards left in the suit. 
                {
                    result = false;
                    break;
                }
            return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            return (cardPack[(int)suit, (int)value] == null);
            
        }
    }
}