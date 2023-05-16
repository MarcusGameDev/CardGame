using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum cardColour { Red, Blue, Yellow, Greeen, Black, Purple, White}

public enum Type { Monster, Option, Tamer, Digitama}

public enum Traits { Dragonoid, Composite, Avian}

public enum Rarity { C, UC, R, SR, SEC, P}

public enum Set { P, BT01, BT02}

public class Card : MonoBehaviour
{
    public int playCost;
    public cardColour[] cardColours;
    public string cardName;
    public Type cardType;
    public Traits[] cardTraits;
    public Rarity cardRarity;
    public Set cardSet;


}
