using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.classes
{
    internal class Deck
    {
        List<Card> cards = new List<Card>();

        public Deck()
        {
            string[] files = Directory.GetFiles("PlayingCards");
            
            // Create 52 unique cards
            int index = 0;
            foreach (Suits s in Enum.GetValues(typeof(Suits)))
            {
                foreach (FaceValues f in Enum.GetValues(typeof(FaceValues)))
                {
                    cards.Add(new Card(s, f, files[index++]));
                }
            }
        }

        public Card DrawCard()
        {
            if (cards.Count <= 0)
            {
                return null;
            }
            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;

        }
    }
}