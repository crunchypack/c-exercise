using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Card
{
    private string face;
    private string suit;

    public Card(string cardFace, string cardSuit)
    {
        face = cardFace;
        suit = cardSuit;
    }
    public override string ToString()
    {
        return face + " of " + suit;
    }
}

public class DeckOfCards
{
    private Card[] deck;
    private int currentCard;
    private const int NUMBER_OF_CARDS = 52;
    private Random randomNumber;

    public DeckOfCards()
    {
        string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        deck = new Card[NUMBER_OF_CARDS];
        currentCard = 0;
        randomNumber = new Random();

        for(int count = 0; count < deck.Length; count++)
        {
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
        }
    }
    public void Shuffle()
    {
        currentCard = 0;
        for (int first = 0; first < deck.Length; first++)
        {
            int second = randomNumber.Next(NUMBER_OF_CARDS);
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }

    public Card DealCard()
    {
        if (currentCard < deck.Length)
        {
            return deck[currentCard++];
        }
        else
        {
            return null;
        }
    }
       
}

public class TestCards
{
    public static void Main (string [] args)
    {
        if(args.Length != 3)
        {
            Console.WriteLine("Error: Re-enter command including \nArray-size, initial value and increment");
        }
        else
        {
            int arrayLength = Convert.ToInt32(args[0]);
            int[] array = new int[arrayLength];

            int initialValue = Convert.ToInt32(args[1]);
            int increment = Convert.ToInt32(args[2]);
            for (int counter = 0; counter < array.Length; counter++)
            {
                array[counter] = initialValue + increment * counter;
            }
            Console.WriteLine("{0}{1,8}", "Index", "Value");
            for(int counter = 0; counter <array.Length; counter++)
            {
                Console.WriteLine("{0,5}{1,8}", counter, array[counter]);
            }
        }
    }
}

