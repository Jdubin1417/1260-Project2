////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project 2 – Hand-Deck-Cards
// File Name: Hand.cs
// Description: Allows Hand objects to be created, copied, and displayed
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
    /// Hand Class creates default hand, then a copy of the hand for the driver to use after the deck has been shuffled.
    /// </summary>
    public class Hand
    {
        //Attributes
        public Card[] GameHand { get; set; }
        public int HandSize { get; set; }
        public int CardsInHand { get; set; }

        /// <summary>
        /// Default constructor of Hand. Default hand sets amount of cards in the hand to zero and amount of cards that CAN be in the 
        /// hand to 5. Can support UP TO 52 Cards in GameHand.
        /// </summary>
        public Hand ()
        {
            CardsInHand = 0;
            HandSize = 5; //Default hand size of 5 in default constructor
            GameHand = new Card[52];
        }

        /// <summary>
        /// Parameterized Constructor of Hand. Allows the integer of HandSize to be passed in to change HandSize of initial constructor
        /// </summary>
        /// <param name="HandSize">Amount of Cards that can be displayed in Hand</param>
        public Hand(int HandSize)
        {
            CardsInHand = 0;
            this.HandSize = HandSize;
            GameHand = new Card[HandSize];
        }

        /// <summary>
        /// Copy constructor of Hand. Makes a copy of already existing Hand.
        /// </summary>
        /// <param name="existingHand">Value to pass existing Hand into method to create copy of Hand</param>
        public Hand(Hand existingHand)
        {
            GameHand = new Card[existingHand.GameHand.Length];
            for (int i = 0; i < GameHand.Length; i++)
            {
                GameHand[i] = existingHand.GameHand[i];
            }
        }

        /// <summary>
        /// Adds card passed through method to the GameHand array.
        /// </summary>
        /// <param name="card">Value to pass a card through method to add it to GameHand</param>
        public void AddACard(Card card)
        {
            if (HandSize > CardsInHand)
            {
                GameHand[CardsInHand] = card;
                CardsInHand++;
            }
        }

        /// <summary>
        /// Converts hand into string that can be displayed by returning "HandStr"
        /// </summary>
        /// <returns>HandStr</returns>
        public override string ToString()
        {
            string HandStr = "";
            for (int i = 0; i < HandSize; i++)    //Loops enough times for entire deck to be shown
            {
                HandStr += GameHand[i].ToString();
            }
            return HandStr;
        }
    }
}
