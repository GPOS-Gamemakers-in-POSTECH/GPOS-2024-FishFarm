using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPoints : MonoBehaviour
{
    private static int actionPoints = 100;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
            ReduceActionPoints(10);

        if (Input.GetKeyDown(KeyCode.T))
            ReduceActionPoints(20);

        if (Input.GetKeyDown(KeyCode.B))
            sleep();
    }

    void ReduceActionPoints(int amount)
    {
        if (actionPoints < amount)
            Debug.Log("Running out of Action Points!");
        else
        {
            actionPoints -= amount;
            actionPoints = Mathf.Clamp(actionPoints, 0, 100);
            Debug.Log("Current Action Points: " + actionPoints);
        }
    }

    void sleep()
    {
        actionPoints = 100;
        Debug.Log("Sleeped Well! All Action Points Restored.");
    }

}
