using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    public Card card; // Variable that can store any inherited class instance

    // Use the card variable as needed
    public void DisplayCard()
    {
        if (card is Monster)
        {
            Monster monsterCard = (Monster)card;
            // Perform operations specific to MonsterCard
        }
       
    }
}
