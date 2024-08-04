using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
public class GrowthRateData
{
    public float avg;
    public float minVar;
    public float maxVar;
    public float baseGrowthRate;
    public float GrowthRateModifier(float curVar)
    {
        return baseGrowthRate * Mathf.Min(Mathf.Max((maxVar - Mathf.Abs(curVar - avg) + minVar) / maxVar, 1), Convert.ToSingle(maxVar > Mathf.Abs(curVar - avg)));
    }
}
[System.Serializable]
public class Fish 
{
    string fishName;
    int fishTier;//1~3 for freshwater, 1~5 for ocean
    FishType fishType;//river/ocean/indoor as 0/1/2
    bool isUnlocked;//Is unlocked by player?
    GrowthRateData waterOxygen;
    GrowthRateData waterDegree;
    Vector2 growthTime;//hatchTime/grownTime

    float baseGrowthRate;//base growth rate
    float minGrowthRate;//minimum growth rate before the countdown starts ticking
    int expirationDate;//date before fish dies

    


    public void DebugPrintInfo()
    {
        Debug.Log($"Fish Name: {fishName}, Fish Type: {fishType}, Fish Tier: {fishTier}");
        Debug.Log($"Water Degree (avg/var): {waterDegree.x}/{waterDegree.y}");
        Debug.Log($"Water Oxygen (avg/var): {waterOxygen.x}/{waterOxygen.y}");
        Debug.Log($"Growth Time (hatch/grown): {growthTime.x}/{growthTime.y}");
    }
}
