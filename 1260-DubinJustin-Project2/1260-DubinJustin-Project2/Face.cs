////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project 2 – Hand-Deck-Cards
// File Name: Face.cs
// Description: Creates ENUM of all faces that can be on a card. (Ace-King)
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Justin Dubin
// Created: Sunday, September 25, 2022
// Copyright: Justin Dubin, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2CardClass
{
    /// <summary>
    /// Enum shows values of all faces for Card. 00-12
    /// </summary>
    public enum Face
    {
        Ace,    //00
        Two,    //01
        Three,  //02
        Four,   //03
        Five,   //04
        Six,    //05
        Seven,  //06
        Eight,  //07
        Nine,   //08
        Ten,    //09
        Jack,   //10
        Queen,  //11
        King    //12
    }

}