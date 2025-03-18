using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum Suits
    {
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum FaceValues
    {
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }
    public class Card
    {
        Suits suit;
        FaceValues faceValue;
        int value;
        Image img;

        public Suits Suit { get { return suit; } }
        public int Value { get { return value; } }
        public Image Image { get { return img; } }

        public Card(Suits suit, FaceValues faceValue, string pathToImage)
        {
            this.suit = suit;
            this.faceValue = faceValue;
            img = Image.FromFile(pathToImage);
            switch(faceValue)
            {
                case FaceValues.ACE:
                    this.value = 11;
                    break;
                case FaceValues.TEN:
                case FaceValues.JACK:
                case FaceValues.QUEEN:
                case FaceValues.KING:
                    this.value = 10;
                    break;
                default:
                    this.value = (int)faceValue;
                    break;
            }
        }

        public override string ToString()
        {
            return this.faceValue + " Of " + this.suit;
        }
    }
}
