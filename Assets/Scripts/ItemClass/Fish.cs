using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum FishType
{
    freshWater = 0,
    river = 0,
    saltWater = 1,
    ocean = 1,
    inDoor = 2,
    both = 2
}
[System.Serializable]
public class Fish 
{
    string fishName;
    int fishTier;//1~3 for freshwater, 1~5 for ocean
    FishType fishType;//river/ocean/indoor as 0/1/2
    bool isUnlocked;//Is unlocked by player?

    Vector2 waterDegree;//avgDegree/varDegree

    Vector2 waterOxygen;//avgOxygen/varOxygen

    Vector2 growthTime;//hatchTime/grownTime

    public void DebugPrintInfo()
    {
        Debug.Log($"Fish Name: {fishName}, Fish Type: {fishType}, Fish Tier: {fishTier}");
        Debug.Log($"Water Degree (avg/var): {waterDegree.x}/{waterDegree.y}");
        Debug.Log($"Water Oxygen (avg/var): {waterOxygen.x}/{waterOxygen.y}");
        Debug.Log($"Growth Time (hatch/grown): {growthTime.x}/{growthTime.y}");
    }
}
