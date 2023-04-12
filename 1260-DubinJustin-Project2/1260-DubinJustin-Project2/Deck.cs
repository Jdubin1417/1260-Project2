////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project 2 – Hand-Deck-Cards
// File Name: Deck.cs
// Description: Creates array of cards as a deck, then creates method to shuffle values
//of deck and creates method to draw cards or hands of cards
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Justin Dubin
// Created: Sunday, September 25, 2022
// Copyright: Justin Dubin, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
using Project2CardClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1260_DubinJustin_Project2
{
    /// <summary>
    /// Deck Class creates default deck, then a copy of that deck. The deck can be shuffled and then cards 
    /// from this deck can be dealt in hands or individual cards.
    /// </summary>
    public class Deck
    {
        //Attributes
        public Card[] DeckCards { get; set; }
        public int NextCard { get; set; }

        /// <summary>
        /// Default constructor of Deck. Default deck that fills array DeckCards with 52 cards
        /// </summary>
        public Deck()
        {
            DeckCards = new Card[52];
            NextCard = 0;

            for (int i = 0; i < 52; i++)    //Loops enough times to add a card for every object in Deck
            {
                DeckCards[i] = new Card(i);
            }
        }

        /// <summary>
        /// Copy Constructor of Deck, creates copy of default constructor
        /// </summary>
        /// <param name="existingDeck">Value to pass existing Deck into method to create copy of Deck</param>
        public Deck(Deck existingDeck)
        {
            NextCard = 0;
            DeckCards = new Card[existingDeck.DeckCards.Length];
            for (int i = 0; i < 52; i++)    //Loops enough times to add a card for every object in Deck
            {
                DeckCards[i] = existingDeck.DeckCards[i];
            }
        }

        /// <summary>
        /// Method that shuffles deck, by replacing values of Deck with 52 random cards 
        /// </summary>
        public void Shuffle()
        {
            Random random = new Random();
            NextCard = 0;
            Card[] DeckShuffled = new Card[52];
            Deck ShufDeck = new Deck();

            for (int i = 0; i < 51; i++)    //Loops enough times for entire deck to be shown
            {
                int rand = random.Next(0,52);
                Card tempCard = DeckCards[i];
                DeckCards[i] = DeckCards[rand];
                DeckCards[rand] = tempCard;
            }
        }

        /// <summary>
        /// Method that deals one card from current deck, and uses a counter to make sure the same card is not dealt twice. 
        /// </summary>
        /// <returns>CardDisplayed</returns>
        public Card DealACard()
        {
            Card CardDisplayed = DeckCards[NextCard];
            NextCard++;     //Keeps track of what card has already been dealt
            return CardDisplayed;
        }

        /// <summary>
        /// Creates a hand of cards by dealing one card (from DealACard method) as many times as handsize integer is specified. 
        /// </summary>
        /// <param name="HandSize">Amount of Cards that can be displayed in Hand</param>
        /// <returns>DealStr</returns>
       public Hand DealAHand(int HandSize)
        {
            Hand Test = new Hand(HandSize); 
            for (int i = 1; i <= HandSize; i++)     //Loops enough times for entire hand to be shown, whatever HandSize is specified as
            {
                Test.AddACard(DealACard()); 
            }
            return Test;
        } 
       
        /// <summary>
        /// Creates string format to display deck of cards properly
        /// </summary>
        /// <returns>CardStr</returns>
        public override string ToString()
        {
            string CardStr = "";
            for (int i = 0; i < 52; i++)    //Loops enough times for entire deck to be shown
            {
                CardStr += DeckCards[i].ToString();
            }
            return CardStr;
        }
    }
}