using System;

namespace CG_7_3_Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a deck of cards
            var deck = new Deck(52);

            //start a counter as we build the deck
            int counter = 0;

            //loop through the face values
            for (int i = 2; i <= 14; i++)
            {
                //loop through the suits
                for (int j = 0; j <= 4; j++)
                {                
                    //set the face values
                string faceValue;

                if (i < 11) faceValue = i.ToString();
                else if (i == 11) faceValue = "Jack";
                else if (i == 12) faceValue = "Queen";
                else if (i == 13) faceValue = "King";
                else faceValue = "Ace";

                //set the suit values
                string suit;
                if (j == 1) suit = "Hearts";
                else if (j == 2) suit = "Diamonds";
                else if (j == 3) suit = "Spades";
                else suit = "Clubs";

                deck.Cards[counter] = new Card
                {
                    FaceValue = faceValue,
                    Suit = suit,
                };

                counter++;

            }
                //draw a card
            var card = deck.Draw();

                //draw rando 2
                var card2 = deck.Draw();

                //show the value
            Console.WriteLine(card.GetFullName());

            Console.ReadLine();

        }
    }

    public class Card
    {
        public string FaceValue { get; set; }
        public string Suit { get; set; }

        /*This is the same as the get/set 
        private string color;
        public string Color
        {
            get
            {
                return_color;
            }
            set
            {
                _color = value;
            }
        }*/


        public string GetFullName ()
        {
            //string Facevalue = Convert.ToString(FaceValue);
            return $"{FaceValue} of {Suit}";
        }
    }

    public class Deck
    {
        public Card[] Cards { get; set; }

        public Deck(int numberofCards)
        {
            Cards = new Card[numberofCards];
        }//This is a constructor and protects you from a null return

         public Card Draw()
        {
            var RdCard = new Random();
            var RandomCard = RdCard.Next(Cards.Length);
            
            return Cards[RandomCard];
        }
    }

}
