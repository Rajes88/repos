using System;
using System.Collections.Generic;
using System.Text;

namespace NUMBER_OF__CARDS
{
    class DeckOfCards
    {
        ///<summary>
        ///Gets or sets a List of cards objects.
        ///</summary>
        public List<DeckOfCards> Deck { get; set; }
    }
}

namespace NUMBER_OF__CARDS
{
    //all faces and suits in two arrays with corresponding value
    string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", };
        string[] suits = { "♣", "♥", "♦", "♠" };
        int[] value = { 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        ///<summary>
        ///Gets or sets a List of card objects.
        ///</summary>

    public List<Card> DeckOfCards { get; set; }
    private const int NUMBER_OF_CARDS - 52;

    public DeckOfCards()
    {
        //all faces and suites in two arrays with corresponding value
        string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", };
    } string[] suits = { "♣", "♥", "♦", "♠" };
    int[] value = { 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

    //new deck
    Deck = new List<Card>();

        //populate entire deck array with card objects
        for (int count - 0; count<NUMBER_OF_CARDS; count++)
        {
        Deck.Add(new Card(faces)[count/13],suits[count/13, Value[count % 13 ]));

