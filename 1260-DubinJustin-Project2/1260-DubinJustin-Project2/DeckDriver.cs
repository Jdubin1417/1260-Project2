////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Project 2 – Deck of Cards
// File Name: DeckDriver.cs
// Description: Creates Initial Deck, then shuffles deck and creates 2 hands of 7 cards with new deck. Then prompts user for amount of
//              players and cards per player.
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Justin Dubin
// Created: Sunday, September 25, 2022
// Copyright: Justin Dubin, 2022
//
/////////////////////////
using Project2CardClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1260_DubinJustin_Project2
{
    /// <summary>
    /// Driver creates hand size, a new deck, then shuffles that deck and displays it along with 2 hands from the shuffled deck
    /// </summary>
    public class DeckDriver
    {
        /// <summary>
        /// Main method of driver class, where all decks are created and modified and hands are displayed
        /// </summary>
        public static void Main()
        {
            int handSize = 7; //Number of cards to be introduced in a hand

            Deck DeckCards = new Deck(); //Creates new Deck
            
           
            Console.WriteLine("The Initial Deck is:" + "\n" + DeckCards); //Displays first Deck (Initial Deck)

            DeckCards.Shuffle();    //Shuffles Deck 1 time
            DeckCards.Shuffle();    //Shuffles Deck 2 times
            DeckCards.Shuffle();    //Shuffles Deck 3 times

            Console.WriteLine("The Second Shuffled Deck is: " + "\n" + DeckCards);   //Shuffled Deck after shuffling 3 times
            
            Deck existingDeck = new Deck(DeckCards);    //New Deck Copied from original deck after it is shuffled 3 times from above
            
            Console.WriteLine("First Hand of Seven Cards:\n" + existingDeck.DealAHand(handSize).ToString());
            Console.WriteLine("Second Hand of Seven Cards:\n" + existingDeck.DealAHand(handSize).ToString());    //Second hand of cards in shuffled deck

            DeckCards.Shuffle();    //Shuffles Deck 1 time
            DeckCards.Shuffle();    //Shuffles Deck 2 times
            DeckCards.Shuffle();    //Shuffles Deck 3 times

            Console.WriteLine("How many cards are in one hand?"); //Prompts user to enter amount of cards for each Player's hand
            handSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many players are playing?");   //Prompts user for number of players playing
            int Players = Convert.ToInt32(Console.ReadLine());
            int Total = handSize * Players; //Amount of cards used in total (Should not exceed 52)

            if (Total < 0 || Total > 52)    //If Statement will provide an error if the total amount of cards being used are not in a deck.
            {
                Console.WriteLine("These players cannot play with one deck of cards!");
                Console.WriteLine("Press ENTER to exit program");
                Console.ReadLine();
            }
            else
            {
                for (int n = 1; n < Players + 1; n++)   //for-loop displays Player hands from user input
                {
                    Console.WriteLine("Player " + n + ":\n" + DeckCards.DealAHand(handSize).ToString());
                }
            }
        }
    }
}