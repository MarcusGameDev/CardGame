using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum dataType { Free, Vaccine, Virus, Data, Unknown}

public enum monsterStage { Digitama, Rookie, Champion, Ultimate, Mega, Hybrid}

public class Monster : Card
{
    public int DP;
    public cardColour[] evolveColourRequirements;
    public int[] evolveLevelRequirements;
    public int[] evolveMemoryRequirements;
    // Add Active Effects
    // Add Inherited Effects
    public dataType cardDataType;
    public monsterStage cardStage;


}
